using System;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace PlayerStates
{
    #region GroundStates
    public class State_Idle : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "idle";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (!_player.OnGround)
            { _player.StateMachine.SetState(EntityState.FALLING); return true; }

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_DOWN)
            { _player.StateMachine.SetState(EntityState.JUMP_TAKINGOFF); return true; }

            if (_player.MovementMagnitude != 0)
            { _player.StateMachine.SetState(EntityState.RUNNING); return false; }
            if (_player.Velocity.x != 0)
            { _player.StateMachine.SetState(EntityState.SLIDING); return false; }
            if (_player.InputHandler.GetVerticalMovement() < 0)
            { _player.StateMachine.SetState(EntityState.CROUCHING); return false; }

            _player.Animator.Play("Idle");

            return true;
        }
        public void FixedUpdate()
        {

        }
    }
    public class State_Running : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "running";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (!_player.OnGround)
            { _player.StateMachine.SetState(EntityState.FALLING); return true; }

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_DOWN)
            { _player.StateMachine.SetState(EntityState.JUMP_TAKINGOFF); return true; }

            if (_player.MovementMagnitude == 0)
            { _player.StateMachine.SetState(EntityState.IDLING); return false; }
            if (_player.InputHandler.GetVerticalMovement() < 0)
            { _player.StateMachine.SetState(EntityState.CROUCHING); return false; }

            _player.Animator.Play("Running");

            return true;
        }
        public void FixedUpdate()
        {
            float targetSpeed = _player.MovementMagnitude * _player.MaxSpeed;
            _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetSpeed, _player.Acceleration);

            if ((_player.FacingDirection > 0 && _player.OnRightWall) || (_player.FacingDirection < 0 && _player.OnLeftWall))
                _player.Velocity.x = 0;

            if (_player.MovementMagnitude > 0)
                _player.FacingDirection = 1;
            if (_player.MovementMagnitude < 0)
                _player.FacingDirection = -1;
        }
    }
    public class State_Sliding : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "sliding";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (!_player.OnGround)
            { _player.StateMachine.SetState(EntityState.FALLING); return true; }

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_DOWN)
            { _player.StateMachine.SetState(EntityState.JUMP_TAKINGOFF); return true; }

            if (_player.MovementMagnitude != 0)
            { _player.StateMachine.SetState(EntityState.RUNNING); return false; }
            if (_player.Velocity.x == 0)
            { _player.StateMachine.SetState(EntityState.IDLING); return false; }
            if (_player.InputHandler.GetVerticalMovement() < 0)
            { _player.StateMachine.SetState(EntityState.CROUCHING); return false; }

            //_player.Animator.Play("Skidding");

            return true;
        }
        public void FixedUpdate()
        {
            _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, 0, _player.Deceleration);
        }
    }
    public class State_Crouching : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "crouching";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.InputHandler.GetVerticalMovement() >= 0)
            { _player.StateMachine.SetState(EntityState.IDLING); return false; }

            _player.Animator.Play("Crouch");

            return true;
        }
        public void FixedUpdate()
        {
            _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, 0, _player.Deceleration * 1.3f);
        }
    }
    public class State_JumpTakingOff : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "jumptakeoff";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            _player.JumpData.CurrentCount = 1;
            _player.JumpData.HighJump = true;

            //Flicker animation

            _player.Velocity.y = _player.JumpForce;
            _player.StateMachine.SetState(EntityState.JUMPING);

            return true;
        }
        public void FixedUpdate()
        { }
    }
    public class State_JumpLanding : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_GROUND;
        public string StateName => "jumpland";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            _player.JumpData.CurrentCount = 0;
            _player.JumpData.HighJump = false;

            //Flicker animation

            _player.StateMachine.SetState(EntityState.IDLING);

            return true;
        }
        public void FixedUpdate()
        { }
    }

    #endregion
    #region AirStates

    public class State_Falling : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_AIR;
        public string StateName => "falling";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.CheckForWallStateChange())
                return false;

            if (_player.OnGround)
            { _player.StateMachine.SetState(EntityState.JUMP_LANDING); return true; }


            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
                if (_player.CanAirJump())
                    return false;

            _player.Animator.Play("Falling");

            return true;
        }
        public void FixedUpdate()
        {
            _player.Velocity.y -= _player.GravityForce;
            if (_player.Velocity.y < _player.MaxFallSpeed)
                _player.Velocity.y = _player.MaxFallSpeed;

            float targetspeed = _player.MovementMagnitude * _player.MaxSpeed;

            if (targetspeed < _player.Velocity.x)
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Deceleration);
            else
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Acceleration);

            if ((_player.FacingDirection > 0 && _player.OnRightWall) || (_player.FacingDirection < 0 && _player.OnLeftWall))
                _player.Velocity.x = 0;

            if (_player.MovementMagnitude > 0)
                _player.FacingDirection = 1;
            if (_player.MovementMagnitude < 0)
                _player.FacingDirection = -1;
        }
    }
    public class State_Jumping : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_AIR;
        public string StateName => "jumping";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.CheckForWallStateChange())
                return false;

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_UP)
                _player.JumpData.HighJump = false;

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
                if (_player.CanAirJump())
                    return false;

            if (_player.OnCeiling)
            {
                //If we hit a ceiling skip jump apex and start falling.
                _player.Velocity.y = 0;
                _player.StateMachine.SetState(EntityState.FALLING);
                return false;
            }
            if (_player.Velocity.y <= 0)
            {
                _player.StateMachine.SetState(EntityState.JUMP_APEX);
                return false;
            }
            
            _player.Animator.Play("Jump_Up");

            return true;
        }
        public void FixedUpdate()
        {
            _player.Velocity.y -= _player.JumpData.HighJump ? _player.GravityForce * .5f : _player.GravityForce;

            float targetspeed = _player.MovementMagnitude * _player.MaxSpeed;

            if (targetspeed < _player.Velocity.x)
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Deceleration);
            else
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Acceleration);

            if ((_player.FacingDirection > 0 && _player.OnRightWall) || (_player.FacingDirection < 0 && _player.OnLeftWall))
                _player.Velocity.x = 0;

            if (_player.MovementMagnitude > 0)
                _player.FacingDirection = 1;
            if (_player.MovementMagnitude < 0)
                _player.FacingDirection = -1;
        }
    }
    public class State_Jump_Apex : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_AIR;
        public string StateName => "jumpapex";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.CheckForWallStateChange())
                return false;

            _player.Velocity.y = 0;

            if (_player.StateMachine.CurrentStateTime >= _player.ApexAirTime)
                _player.StateMachine.SetState(EntityState.FALLING);

            if (_player.InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
                if (_player.CanAirJump())
                    return false;

            return true;
        }
        public void FixedUpdate()
        {
            float targetspeed = _player.MovementMagnitude * _player.MaxSpeed;

            if (targetspeed < _player.Velocity.x)
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Deceleration);
            else
                _player.Velocity.x = Mathf.MoveTowards(_player.Velocity.x, targetspeed, _player.Acceleration);

            if ((_player.FacingDirection > 0 && _player.OnRightWall) || (_player.FacingDirection < 0 && _player.OnLeftWall))
                _player.Velocity.x = 0;

            if (_player.MovementMagnitude > 0)
                _player.FacingDirection = 1;
            if (_player.MovementMagnitude < 0)
                _player.FacingDirection = -1;
        }
    }

    #endregion
    #region WallStates
    public class State_LedgeGrab : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_WALL;
        public string StateName => "ledgegrab";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.InputHandler.GetVerticalMovement() < 0)
            { _player.StateMachine.SetState(EntityState.FALLING); return false; }

            if (_player.InputHandler.KeyDown(PlayerInputHandler.ACTION_JUMP)
                && _player.CanClimbLedge())
                return false;

            _player.Animator.Play("EdgeGrab");

            return true;
        }
        public void FixedUpdate()
        { }
    }
    public class State_LedgeClimb : EntityStateMachine.IEntityState
    {
        public byte StateGroup => EntityStateMachine.STATE_GROUP_WALL;
        public string StateName => "ledgeclimb";

        private PlayerController _player = PlayerController.Instance;

        public bool Update()
        {
            if (_player.StateMachine.CurrentStateTime >= _player.LedgeClimbTime)
            {
                _player.transform.position =
                    _player.transform.position.Swizzle_xy() + new Vector2((_player.CollisionHandler.Width + .05f) * _player.FacingDirection,
                    _player.CollisionHandler.Height + .05f);

                _player.StateMachine.SetState(EntityState.IDLING);
                return false;
            }

            return true;
        }
        public void FixedUpdate()
        { }
    }
    #endregion
}



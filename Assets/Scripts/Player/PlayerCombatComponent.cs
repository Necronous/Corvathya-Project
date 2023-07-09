
using UnityEngine;

public class PlayerCombatComponent : MonoBehaviour
{
    public int _maxCombo = 4;
    public int _currentCombo = 0;

    //Attack cooldown happens when the max combo is reached to prevent player infinitly chaining.
    private (bool Active, float CurrentTime, float MaxTime) _attackCooldown = (false, 0, .5f);

    //combowindow happens after every attack (except the last) if another attack happens in this window its a combo.
    private (bool Active, float CurrentTime, float MaxTime) _comboWindow = (false, 0, 1f);

    private void Start()
    { }

    private void Update()
    {
        if(_attackCooldown.Active)
        {
            _attackCooldown.CurrentTime += Time.deltaTime;
            if(_attackCooldown.CurrentTime >= _attackCooldown.MaxTime)
            {
                _attackCooldown.CurrentTime = 0;
                _attackCooldown.Active = false;
                _currentCombo = 0;
            }    
        }
        if(_comboWindow.Active)
        {
            _comboWindow.CurrentTime += Time.deltaTime;
            if(_comboWindow.CurrentTime >= _comboWindow.MaxTime)
            {
                _comboWindow.CurrentTime = 0;
                _comboWindow.Active = false;
                _currentCombo = 0;
            }
        }
    }

    public void EndAttack()
    {
        if (PlayerController.Instance.StateMachine.GetCurrentStateGroup() != StateGroup.COMBAT)
            return;

        if (_currentCombo >= _maxCombo)
        {
            _attackCooldown.CurrentTime = 0;
            _attackCooldown.Active = true;

            _comboWindow.CurrentTime = 0;
            _comboWindow.Active = false;
            
            _currentCombo = 0;
            
        }
        else
        {
            _attackCooldown.CurrentTime = 0;
            _attackCooldown.Active = false;

            _comboWindow.CurrentTime = 0;
            _comboWindow.Active = true;
        }


        PlayerController.Instance.StateMachine.SetState(EntityState.IDLING);
    }

    public bool TryMeleeAttack(StateGroup sgroup)
    {
        PlayerInputHandler input = PlayerController.Instance.InputHandler;
        PlayerController player = PlayerController.Instance;

        bool heavy = input.KeyPressed(PlayerInputHandler.ACTION_HEAVYATTACK);
        bool light = input.KeyPressed(PlayerInputHandler.ACTION_LIGHTATTACK);

        if (!heavy && !light)
            return false;
        if (!(sgroup == StateGroup.GROUND || sgroup == StateGroup.AIR))
            return false;
        if (_attackCooldown.Active)
            return false;


        //Temporary:: implement velocity into weapon states.
        player.Velocity = Vector2.zero;

        _currentCombo++;
        _comboWindow.Active = false;

        if(sgroup == StateGroup.GROUND)
        {
            if (heavy)
            {
                player.EquipmentHandler.EquipedWeapon.PrimeForGroundHeavyAttack(_currentCombo);
                player.StateMachine.SetState(EntityState.GROUND_HEAVY_ATTACK);
            }
            else
            {
                player.EquipmentHandler.EquipedWeapon.PrimeForGroundLightAttack(_currentCombo);
                player.StateMachine.SetState(EntityState.GROUND_LIGHT_ATTACK);
            }
        }
        else
        {
            if (heavy)
            {
                player.EquipmentHandler.EquipedWeapon.PrimeForAirHeavyAttack(_currentCombo);
                player.StateMachine.SetState(EntityState.AIR_HEAVY_ATTACK);
            }
            else
            {
                player.EquipmentHandler.EquipedWeapon.PrimeForAirLightAttack(_currentCombo);
                player.StateMachine.SetState(EntityState.AIR_LIGHT_ATTACK);
            }
        }

        return true;
    }
}

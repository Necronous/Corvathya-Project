using UnityEngine;

public class Debug_Sword : IWeapon
{
    
    public string WeaponName => "Debug Sword";
    public string StateName => "dsword";
    public StateGroup StateGroup => StateGroup.COMBAT;

    private bool _lightAttack = false;
    private int _combo = 0;
    private string _animation;


    #region Interfaces
    bool skip = true;
    public bool Update()
    {
        EntityAnimation anim = PlayerController.Instance.Animator;
        anim.Play(_animation);

        /* 
         * Animations seem to play on a seperate thread so the new animation isent actually playing yet.
         * So we skip the first frame of the attack to allow the new animation to play otherwise
         * anim.GetCurrentLoopCount() will return the count for the previous/unwanted animation instead
         * and cause the attack to end instantly.
         * Annoying but cannot be helped.
         */ 

        if(skip)
        {
            skip = false;
            return true;
        }
        
        float t = anim.GetCurrentLoopCount();
        if(t > 0)
        {
            PlayerController.Instance.CombatHandler.EndAttack();
        }

        return true;
    }

    public void FixedUpdate()
    {

    }

    public void PrimeForGroundLightAttack(int combo)
    {
        _combo = combo;
        _lightAttack = true;
        _animation = "Sword_LightAttack_1";
        skip = true;
    }

    public void PrimeForAirLightAttack(int combo)
    {
        _combo = combo;
        _lightAttack = true;
        _animation = "Sword_LightAttack_1";
        skip = true;
    }

    public void PrimeForGroundHeavyAttack(int combo)
    {
        _combo = combo;
        _lightAttack = false;
        _animation = "Sword_HeavyAttack_1";
        skip = true;
    }

    public void PrimeForAirHeavyAttack(int combo)
    {
        _combo = combo;
        _lightAttack = false;
        _animation = "Sword_HeavyAttack_1";
        skip = true;
    }
    #endregion

    private bool State_LightAttack()
    {
        return false;
    }
    private bool State_HeavyAttack()
    {
        return false;
    }
}

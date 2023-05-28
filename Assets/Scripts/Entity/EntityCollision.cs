
#define ENTITYCOLLISION_DEBUG

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class EntityCollision : MonoBehaviour
{
    public const int MAX_COLLISION_CONTACTS = 6;
    public const int UP = 0;
    public const int DOWN = 1;
    public const int LEFT = 2;
    public const int RIGHT = 3;

    private BoxCollider2D Collider;

    public float Width => Collider.size.x;
    public float Height => Collider.size.y;
    public float HalfWidth => Width / 2;
    public float HalfHeight => Height / 2;

    public Vector2 Size => Collider.size;

    private (bool Collision, Collider2D Collider)[] _baseCollisionInfo;

    private (bool Collision, Collider2D Collider)[] _upCollisionInfo;
    private (bool Collision, Collider2D Collider)[] _downCollisionInfo;
    private (bool Collision, Collider2D Collider)[] _leftCollisionInfo;
    private (bool Collision, Collider2D Collider)[] _rightCollisionInfo;

    private bool _careAboutPreciseCollisions = false;
    private int _verticalCollisionResolution = 2;
    private int _horizontalCollisionResolution = 4;
    private int _layersToCheck = 0;

    public bool CaresAboutPrecision => _careAboutPreciseCollisions;
    public int VerticalResolution => _verticalCollisionResolution;
    public int HorizontalResolution => _horizontalCollisionResolution;

    public bool UpCollision => _baseCollisionInfo[UP].Collision;
    public bool DownCollision => _baseCollisionInfo[DOWN].Collision;
    public bool LeftCollision => _baseCollisionInfo[LEFT].Collision;
    public bool RightCollision => _baseCollisionInfo[RIGHT].Collision;

    public Collider2D UpCollider => _baseCollisionInfo[UP].Collider;
    public Collider2D DownCollider => _baseCollisionInfo[DOWN].Collider;
    public Collider2D LeftCollider => _baseCollisionInfo[LEFT].Collider;
    public Collider2D RightCollider => _baseCollisionInfo[RIGHT].Collider;

    public (bool Collision, Collider2D Collider)[] GetUpCollisions() => _upCollisionInfo;
    public (bool Collision, Collider2D Collider)[] GetDownCollisions() => _downCollisionInfo;
    public (bool Collision, Collider2D Collider)[] GetLeftCollisions() => _leftCollisionInfo;
    public (bool Collision, Collider2D Collider)[] GetRightCollisions() => _rightCollisionInfo;

    public bool GetUpCollision(int index) => _upCollisionInfo[index].Collision;
    public bool GetDownCollision(int index) => _downCollisionInfo[index].Collision;
    public bool GetLeftCollision(int index) => _leftCollisionInfo[index].Collision;
    public bool GetRightCollision(int index) => _rightCollisionInfo[index].Collision;

    public Collider2D GetUpCollider(int index) => _upCollisionInfo[index].Collider;
    public Collider2D GetDownCollider(int index) => _downCollisionInfo[index].Collider;
    public Collider2D GetLeftCollider(int index) => _leftCollisionInfo[index].Collider;
    public Collider2D GetRightCollider(int index) => _rightCollisionInfo[index].Collider;

    /// <summary>
    /// Set if the entity cares about precise collisions or only basic.
    /// Setting this to true will effect performance so only use it on entities that need it.
    /// The higher the resolution the higher the performance cost.
    /// </summary>
    /// <param name="val">Do we care?</param>
    /// <param name="verticalres">The resolution of vertical precision checks</param>
    /// <param name="horizontalres">The resolution of horizontal precision checks</param>
    public void CareAboutPreciseCollisions(bool val, int verticalres = 2, int horizontalres = 4)
    {
        _careAboutPreciseCollisions = val;
        _verticalCollisionResolution = verticalres;
        _horizontalCollisionResolution = horizontalres;

        _upCollisionInfo = new (bool Collision, Collider2D Collider)[verticalres];
        _downCollisionInfo = new (bool Collision, Collider2D Collider)[verticalres];
        _leftCollisionInfo = new (bool Collision, Collider2D Collider)[horizontalres];
        _rightCollisionInfo = new (bool Collision, Collider2D Collider)[horizontalres];
    }

    public RaycastHit2D Linecast(Vector2 start, Vector2 end)
        => Linecast(start, end, _layersToCheck);
    public RaycastHit2D Linecast(Vector2 start, Vector2 end, int layermask)
    {
        RaycastHit2D hit = Physics2D.Linecast(start, end, layermask);
#if ENTITYCOLLISION_DEBUG
        if(hit)
            Debug.DrawLine(start, end, Color.red);
        else
            Debug.DrawLine(start, end, Color.green);
#endif
        return hit;
    }

    public Collider2D OverlapArea(Vector2 start, Vector2 end)
        => OverlapArea(start, end, _layersToCheck);
    public Collider2D OverlapArea(Vector2 start, Vector2 end, int layermask)
    {
        Collider2D col = Physics2D.OverlapArea(start, end, layermask);
#if ENTITYCOLLISION_DEBUG
        if (col)
            DebugExtensions.DrawBox(start, end, Color.red);
        else
            DebugExtensions.DrawBox(start, end, Color.green);
#endif
        return col;
    }
    
    /// <summary>
    /// Moves the collider to position, Checks for collisions then moves the collider back.
    /// </summary>
    /// <param name="position">Position to check.</param>
    /// <returns></returns>
    public Collider2D Cast(Vector2 position)
        => Cast(position, _layersToCheck);
    /// <summary>
    /// Moves the collider to position, Checks for collisions then moves the collider back.
    /// </summary>
    /// <param name="position">Position to check.</param>
    /// <param name="layermask">Layers to check.</param>
    /// <returns></returns>
    public Collider2D Cast(Vector2 position, int layermask)
    {
        Vector2 start = new Vector2(position.x - HalfWidth, position.y);
        Vector2 end = new Vector2(position.x + HalfWidth, position.y + Height);

        Collider2D col = Physics2D.OverlapArea(start, end, layermask);

#if ENTITYCOLLISION_DEBUG
        if (col)
            DebugExtensions.DrawBox(start, end, Color.red);
        else
            DebugExtensions.DrawBox(start, end, Color.green);
#endif

        return col;
    }

    public bool CollidesWithLayer(int layer)
        => (_layersToCheck & (1 << layer)) == (1 << layer);

    private void Start()
    {
        Collider = GetComponent<BoxCollider2D>();
        _baseCollisionInfo = new (bool collision, Collider2D collider)[4];
        
        int currentlayer = gameObject.layer;
        _layersToCheck = Physics2D.GetLayerCollisionMask(currentlayer);
    }

    private void FixedUpdate()
    {
        UpdateBasicCollisions();
        if(_careAboutPreciseCollisions)
            UpdatePreciseCollisions();
    }

    ContactPoint2D[] _collisionContacts = new ContactPoint2D[MAX_COLLISION_CONTACTS];
    private void UpdateBasicCollisions()
    {
        int contactCount = Collider.GetContacts(_collisionContacts);

        //Reset all collision to false.
        for (int i = 0; i < 4; i++)
            _baseCollisionInfo[i] = (false, null);
        

        for (int i = 0; i < contactCount; i++)
        {
            if (_collisionContacts[i].collider.isTrigger || !CollidesWithLayer(_collisionContacts[i].collider.gameObject.layer))
                continue;

            Vector3 normal = _collisionContacts[i].normal;
            Collider2D collider = _collisionContacts[i].collider;

            //We use the normal to determine the direction of the collider.
            if (Mathf.Abs(normal.x) > Mathf.Abs(normal.y))
            {
                //Its a wall.
                if (normal.x > 0)
                    _baseCollisionInfo[LEFT] = (true, collider);
                else
                    _baseCollisionInfo[RIGHT] = (true, collider);
            }
            else
            {
                //Its floor/ceiling.
                if (normal.y > 0)
                    _baseCollisionInfo[DOWN] = (true, collider);
                else
                    _baseCollisionInfo[UP] = (true, collider);
            }
        }
    }
    private void UpdatePreciseCollisions()
    {
        if (UpCollision) UpdatePreciseCollisionsVertical(1f);
        if (DownCollision) UpdatePreciseCollisionsVertical(-1f);
        if (LeftCollision) UpdatePreciseCollisionsHorizontal(-1f);
        if (RightCollision) UpdatePreciseCollisionsHorizontal(1f);
    }

    private void UpdatePreciseCollisionsVertical(float dir)
    {
        /*
         * Could probably optimise this by only checking against colliders in Collider.GetContacts()
         */

        float yOffset = transform.position.y;
        if(dir > 0)
            yOffset = transform.position.y + Height;
        
        float boxWidth = Width / _verticalCollisionResolution;
        float xOffset = transform.position.x - HalfWidth;

        for (int i = 0; i < _verticalCollisionResolution; i++)
        {
            Vector2 boxStart = new(
                xOffset + (i * boxWidth),
                yOffset
                );
            Vector2 boxEnd = boxStart + new Vector2(boxWidth, .1f * dir);
            Collider2D col = Physics2D.OverlapArea(boxStart, boxEnd, _layersToCheck);

            if (dir > 0)
                _upCollisionInfo[i] = (col != null, col);
            else
                _downCollisionInfo[i] = (col != null, col);

#if ENTITYCOLLISION_DEBUG
            if (col)
                Debug.DrawLine(boxStart, boxEnd, Color.red);
            else
                Debug.DrawLine(boxStart, boxEnd, Color.green);
#endif
        }
    }

    private void UpdatePreciseCollisionsHorizontal(float dir)
    {
        float xOffset = transform.position.x + HalfWidth * dir;
        float boxHeight = Height / _horizontalCollisionResolution;

        for (int i = 0; i < _horizontalCollisionResolution; i++)
        {
            Vector2 boxStart = new(
                xOffset,
                transform.position.y + (i * boxHeight)
                );
            Vector2 boxEnd = boxStart + new Vector2(.1f * dir, boxHeight);
            Collider2D col = Physics2D.OverlapArea(boxStart, boxEnd, _layersToCheck);

            if (dir > 0)
                _rightCollisionInfo[i] = (col != null, col);
            else
                _leftCollisionInfo[i] = (col != null, col);

#if ENTITYCOLLISION_DEBUG
            if (col)
                Debug.DrawLine(boxStart, boxEnd, Color.red);
            else
                Debug.DrawLine(boxStart, boxEnd, Color.green);
#endif
        }

    }
}

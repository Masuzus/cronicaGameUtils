using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebugUtils
{
    /// <summary>
    /// Draws a debug ray in 2D and does the actual raycast
    /// </summary>
    /// <returns>The raycast hit.</returns>
    /// <param name="rayOriginPoint">Ray origin point.</param>
    /// <param name="rayDirection">Ray direction.</param>
    /// <param name="rayDistance">Ray distance.</param>
    /// <param name="mask">Mask.</param>
    /// <param name="debug">If set to <c>true</c> debug.</param>
    /// <param name="color">Color.</param>
    /// <param name="drawGizmo"></param>
    public static RaycastHit2D Raycast(Vector2 rayOriginPoint, Vector2 rayDirection, float rayDistance, LayerMask mask, Color color = default, bool drawGizmo = true)
    {	
        if (drawGizmo) 
        {
            Debug.DrawRay (rayOriginPoint, rayDirection * rayDistance, color);
        }
        return Physics2D.Raycast(rayOriginPoint,rayDirection,rayDistance,mask);		
    }
}

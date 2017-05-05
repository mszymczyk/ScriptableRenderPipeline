using System;
using UnityEngine;

namespace UnityEditor.VFX
{
    [VFXInfo(type = typeof(Vector2))]
    class VFXSlotFloat2 : VFXSlot
    {
        protected override VFXValue DefaultExpression()
        {
            return new VFXValueFloat2(Vector2.zero, false);
        }

        protected override VFXExpression ExpressionFromChildren(VFXExpression[] expr)
        {
            return new VFXExpressionCombine(
                expr[0],
                expr[1]);
        }

        protected override VFXExpression[] ExpressionToChildren(VFXExpression expr)
        {
            return new VFXExpression[2]
            {
                new VFXExpressionExtractComponent(expr, 0),
                new VFXExpressionExtractComponent(expr, 1)
            };
        }
    }
}

using VRageMath;

namespace MultigridProjector.Extra
{
    public static class OrientationAlgebra
    {
        private static readonly bool[] ValidOrientations =
        {
            false,
            false,
            true,
            true,
            true,
            true,
            false,
            false,
            true,
            true,
            true,
            true,
            true,
            true,
            false,
            false,
            true,
            true,
            true,
            true,
            false,
            false,
            true,
            true,
            true,
            true,
            true,
            true,
            false,
            false,
            true,
            true,
            true,
            true,
            false,
            false,
        };

        private static readonly Vector3I[] ProjectionRotations =
        {
            Vector3I.Zero,
            Vector3I.Zero,
            new Vector3I(-2, -2, -1),
            new Vector3I(-2, -2, 1),
            new Vector3I(-2, -2, -2),
            new Vector3I(-2, -2, 0),
            Vector3I.Zero,
            Vector3I.Zero,
            new Vector3I(-2, 0, -1),
            new Vector3I(-2, 0, 1),
            new Vector3I(-2, 0, 0),
            new Vector3I(-2, 0, -2),
            new Vector3I(-1, -2, 1),
            new Vector3I(-1, -2, -1),
            Vector3I.Zero,
            Vector3I.Zero,
            new Vector3I(-1, -2, -2),
            new Vector3I(-1, -2, 0),
            new Vector3I(-1, 0, 1),
            new Vector3I(-1, 0, -1),
            Vector3I.Zero,
            Vector3I.Zero,
            new Vector3I(-1, 0, 0),
            new Vector3I(-1, 0, -2),
            new Vector3I(-2, 1, 0),
            new Vector3I(-2, 1, -2),
            new Vector3I(-2, 1, -1),
            new Vector3I(-2, 1, 1),
            Vector3I.Zero,
            Vector3I.Zero,
            new Vector3I(-2, -1, -2),
            new Vector3I(-2, -1, 0),
            new Vector3I(-2, -1, -1),
            new Vector3I(-2, -1, 1),
            Vector3I.Zero,
            Vector3I.Zero,
        };

        public static Vector3I ProjectionRotationFromForwardAndUp(Base6Directions.Direction forward, Base6Directions.Direction up)
        {
            var index = ((int) forward * 6 + (int) up) % 36;
            return ValidOrientations[index] ? ProjectionRotations[index] : Vector3I.Zero;
        }
    }
}
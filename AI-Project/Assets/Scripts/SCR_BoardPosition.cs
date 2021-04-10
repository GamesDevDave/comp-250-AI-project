using UnityEngine;

namespace Board
{
    public class SCR_BoardPosition : MonoBehaviour
    {
        [Header("Positions.")]
        [Tooltip("X board position.")]
        [SerializeField] private int x;
        [Tooltip("Y board position.")]
        [SerializeField] private int y;

        public SCR_BoardPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }
    }
}


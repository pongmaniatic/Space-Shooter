using UnityEngine;
using PathCreation;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 0.015f;
        
        float distanceTravelled;
        public float HeadStart = 0;
        private float PathLenght;

        public enum MyEnumeratedType
        {
            WaveOne, WaveTwo, WaveThree
        }


        // in your script, declare a public variable of your enum type
        public MyEnumeratedType Wave;


        void Start() {
            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
                distanceTravelled += HeadStart;
            }
            VertexPath path = pathCreator.path;
            PathLenght = path.length;
        }

        void Update()
        {
            if (pathCreator != null)
            {
                distanceTravelled += speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);

                if (Wave == 0)
                {
                    if (distanceTravelled >= PathLenght - 0.193f + HeadStart)
                    {
                        speed = 0f;
                    }
                }
                
            }
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject tilePrefab; // Префаб блоку
    public int width = 10;
    public int height = 10;

    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (Random.value > 0.2f) // 80% шанс на появу плитки
                {
                    Vector3 pos = new Vector3(x, y, 0);
                    Instantiate(tilePrefab, pos, Quaternion.identity);
                }
            }
        }
    }
}

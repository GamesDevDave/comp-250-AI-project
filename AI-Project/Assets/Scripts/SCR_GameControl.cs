using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_GameControl : MonoBehaviour
{

    public GameObject winningText;
    public int whoseTurn;
    public int turnNumber; 
    public Sprite[] icons;
    public Button[] tictactoeSpaces;
    public  int[] markedSpaces; // Changes tile number depending on if the player or AI pressed it;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    void Update()
    {
        if (whoseTurn == 1)
        {
            TemporaryAI();
        }
    }

    void GameSetup()
    {
        whoseTurn = 1;

        for (int i = 0; i < tictactoeSpaces.Length; i++)
        {
            tictactoeSpaces[i].interactable = true;
            tictactoeSpaces[i].GetComponent<Image>().sprite = null;
        }
        for (int i = 0; i < markedSpaces.Length; i++)
        {
            markedSpaces[i] = 0;
        }
    }

    public void TicTacToeButton(int WhichNumber)
    {
        turnNumber++;

        tictactoeSpaces[WhichNumber].image.sprite = icons[whoseTurn];
        tictactoeSpaces[WhichNumber].interactable = false;

        markedSpaces[WhichNumber] = whoseTurn + 1;

        if(whoseTurn == 0)
        {
            whoseTurn = 1;

            CheckForWin();
        }
        else    
        {
            whoseTurn = 0;
        }
    }

    void TemporaryAI()
    {
        List<int> possibleMoves = new List<int>();

        for (int availableSpace = 0; availableSpace < markedSpaces.Length; availableSpace++)
        {
            if (markedSpaces[availableSpace] == 0)
            {   
                possibleMoves.Add(availableSpace);
            }
        }

        CheckForWin();

        int randomIndex = Random.Range(0, possibleMoves.Count);

        TicTacToeButton(possibleMoves[randomIndex]);
        possibleMoves.Clear();
    }

    void CheckForWin()
    {
        int topHorizontal = markedSpaces[0] + markedSpaces[1] + markedSpaces[2];
        int midHorizontal = markedSpaces[3] + markedSpaces[4] + markedSpaces[5];
        int botHorizontal = markedSpaces[6] + markedSpaces[7] + markedSpaces[8];
        int leftVertical = markedSpaces[0] + markedSpaces[3] + markedSpaces[6];
        int midVertical = markedSpaces[1] + markedSpaces[4] + markedSpaces[7];
        int rightVertical = markedSpaces[2] + markedSpaces[5] + markedSpaces[8];
        int diagonalOne = markedSpaces[0] + markedSpaces[4] + markedSpaces[8];
        int diagonalTwo = markedSpaces[2] + markedSpaces[4] + markedSpaces[6];
        var solutions = new int[]{topHorizontal, midHorizontal, botHorizontal,
                                  leftVertical, midVertical, rightVertical,   
                                  diagonalOne, diagonalTwo};

        for (int i = 0; i < solutions.Length; i++)
        {
            if(solutions[i] >= 6)
            {
                Debug.Log("Player 1 won!");
                winningText.SetActive(true);
            }
            else if (solutions[i] == 3) 
            {
                Debug.Log("Player 2 won!");
                winningText.SetActive(true);

            }
            else
            {
                if (turnNumber >= 9)
                {
                    Debug.Log("Draw!");
                    winningText.SetActive(true);
                    return;
                }
            }
        }
    }
}

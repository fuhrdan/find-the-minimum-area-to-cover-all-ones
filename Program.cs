//*****************************************************************************
//** 3195. Find the Minimum Area to Cover All Ones I                leetcode **
//*****************************************************************************
//** Carefully Outlining Vertical Edges Resolves
//** Observing all ones, we mark the furthest rows and columns they reach.
//** Nothing beyond those bounds counts, just the tightest corners that remain.
//** Exact area appears as height times width, the minimum space to enclose them all.
//*****************************************************************************

int minimumArea(int** grid, int gridSize, int* gridColSize) {
    int minRow = INT_MAX, maxRow = INT_MIN;
    int minCol = INT_MAX, maxCol = INT_MIN;

    for (int i = 0; i < gridSize; i++)
    {
        for (int j = 0; j < gridColSize[i]; j++)
        {
            if (grid[i][j] == 1)
            {
                if (i < minRow) minRow = i;
                if (i > maxRow) maxRow = i;
                if (j < minCol) minCol = j;
                if (j > maxCol) maxCol = j;
            }
        }
    }

    int height = maxRow - minRow + 1;
    int width  = maxCol - minCol + 1;
    int retval = height * width;

    return retval;
}

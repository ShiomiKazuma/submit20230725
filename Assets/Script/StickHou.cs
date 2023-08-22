using System;
using UnityEngine;
using Random = System.Random;

public class StickHou : MonoBehaviour
{
    //�ʘH�E�Ǐ��
    const int _path = 0;
    const int _wall = 1;

    public static int[,] GenerateMaze(int width, int height)
    {
        // 5�����̃T�C�Y�ł͐����ł��Ȃ�
        if (height < 5 || width < 5) throw new ArgumentOutOfRangeException();
        if (width % 2 == 0) width++;
        if (height % 2 == 0) height++;

        // �w��T�C�Y�Ő������O����ǂɂ���
        var maze = new int[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                {
                    maze[x, y] = _wall; // �O���͂��ׂĕ�
                }
                else
                {
                    maze[x, y] = _path;  // �O���ȊO�͒ʘH
                }
                    
            }
                
        }
            

        // �_�𗧂āA�|��
        var rnd = new Random();
        for (int x = 2; x < width - 1; x += 2)
        {
            for (int y = 2; y < height - 1; y += 2)
            {
                maze[x, y] = _wall; // �_�𗧂Ă�

                // �|����܂ŌJ��Ԃ�
                while (true)
                {
                    // 1�s�ڂ̂ݏ�ɓ|����
                    int direction;
                    if (y == 2)
                        direction = rnd.Next(4);
                    else
                        direction = rnd.Next(3);

                    // �_��|�����������߂�
                    int wallX = x;
                    int wallY = y;
                    switch (direction)
                    {
                        case 0: // �E
                            wallX++;
                            break;
                        case 1: // ��
                            wallY++;
                            break;
                        case 2: // ��
                            wallX--;
                            break;
                        case 3: // ��
                            wallY--;
                            break;
                    }
                    // �ǂ���Ȃ��ꍇ�̂ݓ|���ďI��
                    if (maze[wallX, wallY] != _wall)
                    {
                        maze[wallX, wallY] = _wall;
                        break;
                    }
                }
            }
        }
        //�f�o�b�O
        DebugPrint(maze);
        return maze;
    }

    // �f�o�b�O�p���\�b�h
    public static void DebugPrint(int[,] maze)
    {
        Console.WriteLine($"Width: {maze.GetLength(0)}");
        Console.WriteLine($"Height: {maze.GetLength(1)}");
        for (int y = 0; y < maze.GetLength(1); y++)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                Console.Write(maze[x, y] == _wall ? "��" : "�@");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        //GenerateMaze maze1 = new GenerateMaze(15, 15);
        //maze1.set_maze_boutaoshi();
        //maze1.print_maze();
    }
}


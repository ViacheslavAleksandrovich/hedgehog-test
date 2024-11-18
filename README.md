# 🦔 Hedgehog Coloring Problem

A C# solution to the Hedgehog Coloring Problem, where the goal is to determine the minimum number of meetings required to unify the colors of a population of hedgehogs.

The population consists of three groups of hedgehogs, each of a different color: Red, Green, and Blue. Through a series of meetings, the hedgehogs can swap colors to make their populations uniform. This solution employs Breadth-First Search (BFS) to find the minimum number of color swaps required to make all hedgehogs the same color.

🧩 Problem Overview

The problem is to determine the minimum number of meetings (color swaps) needed to make all hedgehogs the same color. The hedgehogs can swap colors according to the following rules:

Red and Green hedgehogs can swap colors.
Green and Blue hedgehogs can swap colors.
Blue and Red hedgehogs can swap colors.

Input. An array population[], where:

1. population[0] is the number of Red hedgehogs.

2. population[1] is the number of Green hedgehogs.

3. population[2] is the number of Blue hedgehogs.

A target color (0 for Red, 1 for Green, and 2 for Blue).

Output:

The minimum number of meetings required to make all hedgehogs the target color.

If it's not possible to make all hedgehogs the target color, return -1.

🚀 Features

Breadth-First Search (BFS): Utilized for finding the optimal solution.
Efficient State Tracking: Implements a queue and a visited set to avoid redundant checks and ensure efficiency.
Edge Case Handling: Handles multiple populations and target colors, including edge cases such as already uniform populations or unreachable configurations.

🛠️ How It Works

This solution uses a BFS approach to explore all possible color configurations and find the minimum number of steps required to achieve a uniform color for all hedgehogs.

Each state represents the count of Red, Green, and Blue hedgehogs. The BFS algorithm ensures the minimum steps are calculated by expanding from each state and examining possible color swaps.

🚀 How to Run

Clone the Repository:

git clone <https://github.com/your-username/hedgehog-coloring.git>

cd hedgehog-coloring

Run the Solution:

dotnet run

📜 License

This project is licensed under the MIT License. Feel free to use, modify, and distribute it as you wish.

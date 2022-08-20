# Robot Move Game Simulation  

The game initialises with an empty 5 x 5 board with the bottom left of the board is (1, 1) (row 1, column 1), and the top right corner of the board is (5, 5).

### Commands

#### 1. PLACE_ROBOT ROW,COL,FACING
 If there are no robots on the board, the PLACE_ROBOT places one at the coordinate specified and If there is already a robot, a new PLACE_ROBOT command moves the existing robot to the new location.
 ```bash

PLACE_ROBOT 2,3,NORTH

```
This places a robot at row 2, column 3, facing North.

#### 2. PLACE_WALL ROW,COL
• If the target location is empty, then it adds a wall to it.
• The user can add as many walls as they like until the board is filled.
• If the target location is occupied (by the robot, or another wall), then this command is ignored.
 ```bash

PLACE_WALL 2,3

```
This places a wall at row 2, column 3.

#### 3. Report
Report the current location of the robot

#### 4. MOVE
The MOVE command moves the robot 1 space forward in the direction it is currently facing.
• If there are no robots on the board, this command is ignored.
• If there is a wall in front of the robot, this command is ignored.
• If the robot has already reached the edge of the board, a MOVE command towards the edge warps
the robot to the opposite side of the board

#### 5. LEFT / RIGHT
The turn commands LEFT and RIGHT, turns the robot 90 degrees to its current left or right
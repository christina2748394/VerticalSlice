# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. I used Visual Scripting Graph for my state machine. Currently there is an Idle State that is the starting node and a Runnning State. It controls when the charactor switches between states by detecting horizontal input, and changes the charactor animation to match the state by changing the bool value from the animator.

2. [New Break-Down](https://docs.google.com/drawings/d/1VlxVvg0mTTwS7AS_746No2ra2WYkIBEiiZcvD8d0nSM/edit?usp=sharing)

3. I updated my break-down with the state machine connected with animator. In my state machine there are Idle and Running State. In Each state the IsRunning bool from the animator is set to a different value. OnUpdate() in transition from Idle to Running state get the horizontal input from player and if the value is not equal to 0, it fires the transition to Running State. Transition from Running state to Idle works the same except detecting when the horizontal input is euqal to 0. Each state gets a reference to the player animator component through an object variable inorder to access the SetBool function. The bool IsRunning then controls the animation transaction in animator.

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!

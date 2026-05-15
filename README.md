# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. I used Visual Scripting Graph for my state machine. Currently there is an Idle State that is the starting node and a Runnning State. It controls when the charactor switches between states by detecting horizontal input, and changes the charactor animation to match the state by changing the bool value from the animator.

2. [New Break-Down](https://docs.google.com/drawings/d/1VlxVvg0mTTwS7AS_746No2ra2WYkIBEiiZcvD8d0nSM/edit?usp=sharing)

3. I updated my break-down with the state machine connected with animator. In my state machine there are Idle and Running State. In Each state the IsRunning bool from the animator is set to a different value. OnUpdate() in transition from Idle to Running state get the horizontal input from player and if the value is not equal to 0, it fires the transition to Running State. Transition from Running state to Idle works the same except detecting when the horizontal input is euqal to 0. Each state gets a reference to the player animator component through an object variable inorder to access the SetBool function. The bool IsRunning then controls the animation transaction in animator.

## Milestone 2 Devlog
1. Complicating Game feature: A math puzzle that player will need to solve before proceeding in the story(dialogue).
Big steps:
- Add room state controller
  1. Add State Machine to Story manager
  2. Step up basic states and transitions
  3. Create variables that reference the puzzle game objects and function that the graph can call.
- Add math puzzle that player can solve
  1. Modify the Crafting manager to contain more slots
  2. Set up the recipe to contain correct math answers
  3. Create number items that can be draged into slots
After Coding:They were helpful because it lets me plan out which task to start on and make it easier to get to work. Though next time I will consider adding the time estimate for each task to avoid spending too long stuck on one feature. 

2. I called multiple C# functions from my Room StateMachine graph. For example, I called the ShowStartDialogue()Function from the Intro State of my State Machine to let dialogue appear when player first entered the level. [Graph](https://github.com/user-attachments/assets/42209d13-eed7-443d-9653-b12c1084e49d)
3. I hope to be graded on StateMachine of the room because it controlls player action in each state to help my story proceed. For example in the intro state, Dialogue is shown and player can not move yet, while Puzzle phase enabled player to explore and interact with item that open the Puzzle canvas. Completing the Puzzle will trigger to new dialogue state which close the Puzzle canvas and begin a new dialogue story.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!

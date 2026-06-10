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
1. My shader Graph is a full screen texture that lay on top on game to create a darken view. The color of the texture loops from black to grey using Lerp node with the SinTime method, also modified with math so that color will not go all the way to white.
[Shader Graph](https://github.com/user-attachments/assets/e082c706-c6a8-4f43-a8df-b65bcefa8dcd)
2. I changed the sequence of first math puzzle to lower the level of diffculty according to player feedback that the harder one may take up too much time. I also added the shader graph that loop from dark black to light grey to create a fade in effect from feedback that transition from reality to dream level feel more realistic.
3. I added start menu, an intro cutscene using video player and branching dialogue, a new level between soup making and entering the dream, Character sprite, shader graph and improved dialogue/puzzle for the dream level, changed camera perspective and some game play logic to match that. 

## Final Devlog

### Question1
The game currently contains a start menu, an intro cutscene with simple animation and dialogue choices, Day 1 scene where Player can move around in a room , A transition scene between Day1 and Dream1 where the Player enter a portal, Dream1 Scene switch the view to first person camera and loops between dialogue with NPC and solving 2 math puzzles, the last puzzle will be timed and whether the player complete the puzzle or not in this time will lead to 2 different ending states, triggering change in shader.

The core game play loop for player is reading dialogues, moving and interacting with item to open puzzle, and solving puzzle to proceed dialogue.

This content illustrates to the player that the full game would an interactive story experience themed around getting go of heartbreak. The story will be portrayed with dialogues, cutscenes and NPC sprites switching between third person and first person view, and Player will solve puzzle by dragging items or numbers into the correct slot to proceed in the 3 dreams.

### Question2
My Rendering Effect is activated in state machine graph by Material Change Color Node that changes the Material’s Color property as Game enter EndingScary state. In my Dream1 Scene, I used a full screen effect on main camera called HimEffect with HimShader as material. The Shader Graph on HimShader Contains a Color Property called Color that gets multiplied with the full screen texture. The Color is set to white using Material Set Color node when the player first entered the Intro State in Dream1. Then when the game in Dream1 Proceed to EndingScary State, the Material Set Color node is called again by the state machine graph in the story manager, this time setting Color to red.
<img width="987" height="768" alt="截屏2026-06-09 10 34 22" src="https://github.com/user-attachments/assets/af8c97ee-a3e6-4c41-95e0-66ca9c90c4e5" />

### Question3
I plan on using both bubble diagram break-down and task step break-down. Starting with bubble diagram break-down lay out all the systems needed and how they are connected. This helps me to decide if I need to cut down some systems and which systems to do first as others might be dependent. Then according to the sequence I can make task step break-down. 

Breaking a large project in to small steps help me get a more accurate time estimate. As it is much   easier to estimate the time needed for a single task and add them up than to foreseen the time needed for an entire project. It also helps me see how they would fit in to weekly progress with the current time I have. In all having detailed break down help me understand how much time the project will need throughout the weeks and see if the plan is out of scope.

One thing I want to change for my next project is to put completing a story line as the first task before laying out bubble diagram and starting the code. During this game the story I wanted to tell had changed during development and therefore affect a lot on how I want to use game mechanic. Though I like the way it end up being, it does linger on progress sometimes when I was coding systems before settling on a final plot and I had to spend extra time changing the system back and forth. Other than that bubble diagram have worked great to help me come up with more efficient ways to connect system and the task break down. I would definitely want to repeat using those process in my future projects.

## Open-source assets
Character and animation made with [Character Creator](https://pixel-no-okoku.itch.io/pixel-character-creator) 

Craft Item by [Fågeltomten](https://fageltomten.itch.io/pixel-items)

Craft Slot Ui by [Admurin ](https://admurin.itch.io/)

Cauldron by [Seneneves](https://sevenevesai.itch.io/alchemy)

Furniture by [Ipixl](https://itch.io/queue/c/7280761/33?game_id=703945&password=)

BrickWall Background by [Gracitation](https://gracitation.itch.io/old-brick-wall-and-parchment-paper)

PixelPortal by [f1xtach](https://f1xtach.itch.io/pixel-art-portal)

UI Numbers by [Yusa Studios](https://yusastudios.itch.io/pixelated-buttons)

UI Math by [Renderman](https://hcgamestudios.itch.io/math-game-assets)

Audio by  [Leonardo Calvo](https://thesoundrack.itch.io/sad-music-pack)

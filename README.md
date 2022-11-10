As of 11/10/2022

Is git/unity working?

- troubleshoot if not
- create a new branch then merge (asynchronous) or merge to main as soon as possible (synchronous)

TODO below

added hip for stability

- add hip arts assets to replace square placeholder

play with parameters to achieve a smoother/more fun walking/running/jumping experience

(maybe separate these to 2 (walking & jumping) or 3 tasks)

- angles for legs (how wide can legs move)
- speed for movement (forces applied to leg movement)
- physics material 2D (lower leg & floor) friction/bounce

basic level ideas

- interactive objects
    - box to grab?
    - ropes to climb?
- static objects
    - terrains
    - holes
    - slopes
- sketches
- potential art assets
- themes

global control

- change selected limbs on (W/S, up/down Arrow key)
- color code selected limbs

decide hand UI - maybe till tomorrow, need some time to think about it

- currently arm + forearm + hands
- compare to legs controller
    - legs: only thigh is controllable
    - hand: more flexible?
- interaction key?
    - for grabbing
    - hand control with more precision

code clean up

- Do we need bones for animation?
    - keep it for now

interesting thoughts

- only one player in charge of movement
    - other player can interact with the map for example
- play with bounciness of floor materials to get higher jumping?
- gravity

List of stuff to work on

- [ ]  add hip art assets
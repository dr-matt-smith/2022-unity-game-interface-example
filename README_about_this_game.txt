Game to illustrate interfaces

see _Scripts / Tudublin / IDamageable.cs

player 1 - pink haired girl - control with arrow keys
controller code is: 
Player.cs
this class implements IDamageable -  so has  method Damage(int)

player 2 - girl with crown - control with WASD
controller code is: 
Player2.cs
this class does  NOT implements IDamageable

The red stars have an instance of DangerousObject and the poison bottle has an instance of KillingObject
each of these has logic in the OnTriggerEnter to test whether the object that HIT the collider contains a component that imnplements IDamageable

so when player1 hits red star / poison bottle, it will apply Damage, and reduce health
when player2 hits red star / poison bottle, no damage is applied

---
note - this isn't the best solution for this game, but it a solution that illustrates how interfaces work :-)


---
note - this also illustrates the symmetry of OnTriggerEnter collision messages
BOTH objects are sent OnTriggerEnter with a reference to the other object
so if a player character hits a star or poison bottle, bother the player object and hit object receive OnTriggerEnter messages

so in Unity we can CHOOSE / DESIGN where best to put our logic

for collecting stars, we have logic on the Player objects, detecting collisions with stars and updating score
for damage, we have logic on the Dangerous/Killing objects, detecting collisions with players

if you do want all/most logic on the player, avoid having one big Player class - break it up with a class per-behavioural feature

---

OnTriggerEnter is an example of inheritance and method overriding
so the classes we write to become components of GameObjects have to subclass/extend MonoBehaviour
MonoBehaviour has many empty methods, for all the different event messages GameObjects can recevied (Awake(), Start(), Update(), OnTriggerEnter() etc.)
when we write a class that subclasses MonoBehaviour, and in our class we write an OnTriggerEnter() method, 
we are OVERRIDING the empty inherited method and replacing it with our own collision logic

read about this superclass in the Unity documentation:
https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
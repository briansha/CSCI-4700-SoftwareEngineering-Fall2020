# CSCI-4700-SoftwareEngineering-Fall2020
Unity-based team project for Vanderbilt clients

System Statement of Scope

I.	Scope Statement

A.	This project involves the development of a VR environment that works alongside robotic systems focused on enhancing social engagement among older adults with mild cognitive impairment or dementia that live in long-term care settings. The VR environment will be developed using Unity and will be skeletal in nature where additional activities can easily be added to it. The environment will be non-immersive, as some users would not prefer wearing headsets. The users this project is specifically targeting are patients who reside in long-term care settings suffering from apathy. This specific project will be focused on the development of painting tasks that pairs of older adults will work together on to finish painting the provided image using the correct colors and tools in the environment. The robot will act as another player with only one participant, and offer encouragement and feedback with two or more participants.

II.	Functionality

A.	Our painting task will be developed using the Unity Engine, and the primary interface, at least for development, will be keyboard and mouse, with later expansion for physical “brushes” as input. The product will provide a canvas system and a color palette that the user can use to paint in certain images or to create novel images. The “owners” of the system will be faculty at the nursing facility, and participants will be one or more impaired patients tasked with painting or completing sample images. Information in the system will be updated as users color the canvas with varying brush sizes, intensities, and colors. The goal of this system is to improve patient cognition, cooperation, and apathy. The only special interface will be physical brush tools. The canvas will be non-immersive and exist only on a computer monitor.

III.	Input / Output Data: 

A.	Our painting task contains different levels  and each level contains different tasks. Level 1 is the “paint by number” task. It will take an image as an input from the device and convert  to its  number version. 
B.	This project will take the input from users to paint on its painting canvas for the second level. We're using a mouse and keyboard as an input device. In this project, there will be two participants (players), and both of them are able to choose color and its intensity. Similarly, they will have a brush to paint on the canvas with the different size so that participants can choose the brush accordingly.  
C.	There will be the default coordinates A(0,0). Arrow keys and A, W, S, D are responsible for reading the axis using the keyword Input.GetAxis. Similarly, the left key of the mouse is responsible to choose different colors and brush size and drag to canvas. Right key will be responsible to fill the color on a certain closed area and undo. 

IV.	Users/Stakeholders:

A.	The primary users for this project are the activity coordinators for the particular nursing facilities that this project is given to. The activity coordinator will then grant use this to help their patients who are elderly patients in varying stages of cognitive decline (secondary users). The primary users will use the user interface to give the secondary users drawing tasks with varying degrees of difficulty. They will also use the interface to save the patient’s name, time spent, difficulty setting, and accuracy to an excel file. One secondary user will use an input device (keyboard and mouse and later a magic wand device) to perform paint by numbers tasks of varying difficulty. The patient will have multiple colors to choose from. The second secondary user will give the user feedback. If there is only one secondary user, a robotic companion will give feedback instead. The users are not required to have in-depth knowledge on computer systems to use this project. Reading the user manual will provide adequate insight into how the project functions.

B.	The caregivers taking care of the elderly at the nursing home will be in charge of making sure the user is logged in and using it appropriately. They will be trained on how to handle the basic maintenance. 

V.	Security and Performance Requirements:


A.	The performance aspect the system/application will support up to two users/clients at a time and log their user ids and also their time logs and possibly accuracy and completion of such tasks, so that the task managers can interpret said data. 

B.	Understanding the scope and use of this application, there should not be many security risks as this application will not be logging any personal sensitive information and will just be using user IDs to relate to the data stored. With that said security and performance demands of the application are lax.

**Features Brainstorm**
- Dynamic character sheet players can use to track their stats while playing at the table
- Character creation tool, to step by step introduce each part of creating a character
	- Should also be used as a method to gather user input to build the character sheet from
- Rules glossary, contain a library of the rules so they can be easily referred to
- Server base to allow the dungeon master a place to view all the character sheets in a campaign
	- Allowing the DM to see live changes during play
- Character sheets and their states after live play should be persistent

**Minimal Viable Product**
The MVP for the current timeframe is to have a static character sheet that is built from a simplified character tool.
A user should be able to step through the character creation and get a character sheet as output. This will not include
character abilities, but only the main attributes of the character.

**User Story**
As a player
I should be able to create a character
So that I have a character sheet to reference during live play

**Structure**
Overall the project is split into four sections; UI, database, back-end, and Maui. Of these sections I will focus on the UI
and back-end. The database will be handled in a future iteration of the project. Maui is its own section but is built
within the rest of the program as it acts as the connective tissue between the other sections.

The UI will further have subsections. The character creation tool and the character sheet.

The back-end will be split between the character hierarchy and user input.

There may be an expansion on these sections as features are completed and stretch goals are potentially attainable during
this timeframe.
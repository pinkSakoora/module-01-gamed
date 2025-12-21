## Hey there!
This repository contains the source code for a model submission for the first module of DevSoc's GameDev Vertical. 
> [!NOTE] 
> This was built in Unity Editor `v6000.0.64f1` (LTS), which has quite a few differences from the editor used in the provided playlist. Since the playlist is quite dated (>8 years old), I would personally suggest to learn how to use a recent LTS version (such as the one used in this repo.)

This project is still very much a _work in progress_! This means incomplete features, hardcoded values, questionable code that could be changed at any moment, and generally not a very polished experience.

## Table of contents
- [Differences in Editors used](#differences-in-editors-used)
- [Differences in mechanics](#differences-in-mechanics)
- [Useful resources](#useful-resources)
  - [.gitignore](#gitignore)
  - [git basics](#git-basics)
  - [commiting](#committing)
  - [New Input System](#new-input-system)
- [This repository](#this-repository)

## Differences in Editors used
The playlist uses Unity Editor `v5.5.0f3` (released on Nov 16, 2016), vs `v6000.0.064f1` (released on May 21, 2024) which is used in this project. That's nearly 8 years of difference, so there are a [LOT of differences](https://alpha.release-notes.ds.unity3d.com/search?from_release=5.5.0f3&to_release=6000.0.64f1) (3090 pages of it!) Of course, most of these won't make sense to the reader (or to me, honestly), so some of the noticeable changes are:  
- A different editor UI
- Usage of the New Input System in favor of Input Manager
- Other minor stuff \(such as MonoBehaviour Script being the default script you create within editor\)

However, most of the stuff in the playlist are still conceptually the same, the only exception being the input system, which is covered in a later section.

## Differences in mechanics
This project has some differences in the way things are implemented, as well as removal and addition of certain mechanics:
- Infinitely long, procedurally generated levels
  - Usage of obstacle prefabs instead of unique obstacles to allow for infinite random generation
  - Obstacles moving towards player instead of the other way around, to avoid unexpected behavior at extremely high scores
- Usage of obstacle sets to provide a balanced series of obstacles instead of true random generation
- And more to be added as the project progresses.

## Useful resources
This section contains stuff that may prove to be useful to you while you make your project

### .gitignore
From the git docs:
> A `.gitignore` file specifies intentionally untracked files that Git should ignore.

As the name implies, a `.gitignore` makes git ignore files that match the pattern provided within it. This is useful when you want certain files (such as temporary files, cached assets, sensitive information, etc.) to not be tracked.
Further reading:
- [git docs](https://git-scm.com/docs/gitignore) - More information, patterns used, configuration, and more.
- [Unity.gitignore](https://github.com/github/gitignore/blob/main/Unity.gitignore) - The official Unity `.gitignore` that you should place in the root directory of your Unity project folder, after renaming it to just `.gitignore`

### git basics
- [cheat sheet](https://git-scm.com/cheat-sheet) - A cheat sheet for most of the git commands you may need
- [Git It? How to use Git and Github - Fireship](https://youtu.be/HkdAHXoRtos?si=LygbTGejpcLgH1Qv) - A hands-on guide explaining the most commonly used features of git
- [How to use GitHub with Unity - Brackeys](https://youtu.be/qpXxcvS-g3g?si=6YieJFkeHY10W9ar) - A GitHub specific guide on getting your Unity project set up. I personally **do not recommend** using GitHub Desktop and instead doing the same using the terminal as this familiazes you with the CLI.

### committing
It is generally recommended to keep the scope of your commit (as in how many different components you change) narrow. An example would be a project in which you have different parts, such as player movement, UI, sounds, enemy logic and environment. It is a good practice to keep one commit restricted to only one part, instead of, say, changing both player movement and the environment in the same commit. This makes the commit history easier to go through, as having only one part affected by a commit can allow you to track the changes of that part more easily than having it affected along with multiple other parts in the same commit.  

It is also recommended to keep your commits short and small in changes, so as to make reverting in cases of failure easier and less of a headache, as would have been in case of a large commit.  

As for naming, just keeping a brief description of what was changed is usually sufficient for small projects. What is not okay is commit messages like `new stuff`, `changed some things`, and so on. It's easier on both yourself and any potential collaborators if your commit messages already describe what's going on in the commit, instead of having to dig deeper and look at the differences between files manually. But if you want to really get fancy with the naming and follow a certain standard, [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) is generally used \([non-official cheat sheet](https://gist.github.com/qoomon/5dfcdf8eec66a051ecd85625518cfd13)\)

### New Input System
The new Input System was made the default way to handle user inputs starting Unity 6. There still exists a [way to revert to the old Input Manager](https://www.youtube.com/shorts/FFHuSvU85Ho), but it is worthwhile to learn how to use the new Input System.

## This repository
This section contains information and tidbits pertaining to this repository in particular. TBA.
- [How to use Unity's New INPUT System EASILY - BMo](https://youtu.be/HmXU4dZbaMw?si=TaGJ2v-NYTMWNaG7) - A quick guide on how to switch from Input Manager to Input System in your code \(which also doubles as a quick look into the Input System.\)
- [Input System Tutorials - Unity](https://youtube.com/playlist?list=PLX2vGYjWbI0RpLvO3B7aH-ObfcOifMD20&si=0F2NNsCNtr7xAIXd) - A full playlist containing official tutorials from Unity itself, that goes in depth (perhaps too much) into setting up and using the Input System.

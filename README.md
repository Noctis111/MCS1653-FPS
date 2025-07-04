# Unity 3D Project Template 2022.3.55
# based on Jeremy Bond's MSU MI 231 Template

**This project template for all Unity 2022.3 projects in MCS 1653 includes:**
* A Unity project template that includes the correct .gitignore and .gitattributes files to work with GitHub. You won't see the .git___ files because they are invisible, but they help GIT work well with Unity projects.
* **This README.md MarkDown file.** You will need to edit the **Required ReadMe Info** section below for ***EVERY*** project in this class.
* A UnityWindowLayout.wlt file in the project folder (the same folder as this ReadMe.md file) that you can load to lay out the Unity window the way that Peter prefers.
* Modifications to the base Unity project that **remove Plastic SCM**, which is extremely helpful for allowing Git to work well.

---

# Required ReadMe Info for ALL MCS1653 Projects
* **Project**   - DriftRunner
* **Your Name** - Alain Dauphin
* **Date**      - 5/5/25

<br>

1. **What are the controls to your game? How do we play?**
WASD - Move
Spacebar - Jump
Left Click - Shoot
Right Click - Grapple

<br>

2. **What creative additions did you make? How can we find them?**
While I'm not sure how to exactly answer "creative additions", the main keypoints of this game is its movement. My strongest focus was making the player feel as floaty as possible, while also grounding the player in realistic movement (such as momentum or 'speed' decay in air decreases when you start to fall). 

<br>

3. **Any assets used that you didn't create yourself?** <br> (art, music, etc. Just tell us where you got it, link it here)
Hearts - https://fliflifly.itch.io/hearts-and-health-bar?download
Music - https://www.gamedevmarket.net/asset/action-game-music-pack-free

<br>

4. **Did you receive help from anyone outside this class?** <br> (list their names and what they helped with)
I received no outside help

<br>

5. **Did you get help from any AI Code Assistants?** <br> (Tell us which .cs file to look in for the citation and describe what you learned)
The main assistance I received from AI was solving any bugs that I had. I wanted to be able to naturally write as much code as I could, with AI guiding me on how to properly structure my code and reduce the amount of time I had to spend on solving any bugs. Because of that I learned a good deal of how to make classes and how to interact with Unity and it's editor from scripting.

<br>

6. **Did you get help from any online websites, videos, or tutorials?** <br> (link them here)
Scripts inspired by - Dave Game Development (https://www.youtube.com/playlist?list=PLh9SS5jRVLAleXEcDTWxBF39UjyrFc6Nb)


<br>

7. **What trouble did you have with this project?**
Since I'm more familiar with creating FPS games, I didn't have much struggle. However a lot of my time had gone into tweaking the movement's scripts from Dave Game Development. I used his code as a basis for what I needed, but there were more pieces I had to add myself such as the airspeed. 


<br>

8. **Is there anything else we should know?**
Some stuff I didn't know where to include in the game:
The red dots will damage you if you past them, shoot them to destroy
If you shoot the red glowing platforms, they will turn yellow and allow you to bounce on them
Land on green platform to win the level



<br><br><br><br><br>

---

#
---


# Default GitLab README Content is Below
To make it easy for you to get started with GitLab, here's a list of recommended next steps.

Already a pro? Just edit this README.md and make it your own. Want to make it easy? [Use the template at the bottom](#editing-this-readme)!

## Add your files

- [ ] [Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files
- [ ] [Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:

```
cd existing_repo
git remote add origin https://gitlab.msu.edu/mi231-f22/templates/unity-project-template.git
git branch -M main
git push -uf origin main
```

## Integrate with your tools

- [ ] [Set up project integrations](https://gitlab.msu.edu/mi231-f22/templates/unity-project-template/-/settings/integrations)

## Collaborate with your team

- [ ] [Invite team members and collaborators](https://docs.gitlab.com/ee/user/project/members/)
- [ ] [Create a new merge request](https://docs.gitlab.com/ee/user/project/merge_requests/creating_merge_requests.html)
- [ ] [Automatically close issues from merge requests](https://docs.gitlab.com/ee/user/project/issues/managing_issues.html#closing-issues-automatically)
- [ ] [Enable merge request approvals](https://docs.gitlab.com/ee/user/project/merge_requests/approvals/)
- [ ] [Automatically merge when pipeline succeeds](https://docs.gitlab.com/ee/user/project/merge_requests/merge_when_pipeline_succeeds.html)

## Test and Deploy

Use the built-in continuous integration in GitLab.

- [ ] [Get started with GitLab CI/CD](https://docs.gitlab.com/ee/ci/quick_start/index.html)
- [ ] [Analyze your code for known vulnerabilities with Static Application Security Testing(SAST)](https://docs.gitlab.com/ee/user/application_security/sast/)
- [ ] [Deploy to Kubernetes, Amazon EC2, or Amazon ECS using Auto Deploy](https://docs.gitlab.com/ee/topics/autodevops/requirements.html)
- [ ] [Use pull-based deployments for improved Kubernetes management](https://docs.gitlab.com/ee/user/clusters/agent/)
- [ ] [Set up protected environments](https://docs.gitlab.com/ee/ci/environments/protected_environments.html)

***

# Editing this README

When you're ready to make this README your own, just edit this file and use the handy template below (or feel free to structure it however you want - this is just a starting point!). Thank you to [makeareadme.com](https://www.makeareadme.com/) for this template.

## Suggestions for a good README
Every project is different, so consider which of these sections apply to yours. The sections used in the template are suggestions for most open source projects. Also keep in mind that while a README can be too long and detailed, too long is better than too short. If you think your README is too long, consider utilizing another form of documentation rather than cutting out information.

## Name
Choose a self-explaining name for your project.

## Description
Let people know what your project can do specifically. Provide context and add a link to any reference visitors might be unfamiliar with. A list of Features or a Background subsection can also be added here. If there are alternatives to your project, this is a good place to list differentiating factors.

## Badges
On some READMEs, you may see small images that convey metadata, such as whether or not all the tests are passing for the project. You can use Shields to add some to your README. Many services also have instructions for adding a badge.

## Visuals
Depending on what you are making, it can be a good idea to include screenshots or even a video (you'll frequently see GIFs rather than actual videos). Tools like ttygif can help, but check out Asciinema for a more sophisticated method.

## Installation
Within a particular ecosystem, there may be a common way of installing things, such as using Yarn, NuGet, or Homebrew. However, consider the possibility that whoever is reading your README is a novice and would like more guidance. Listing specific steps helps remove ambiguity and gets people to using your project as quickly as possible. If it only runs in a specific context like a particular programming language version or operating system or has dependencies that have to be installed manually, also add a Requirements subsection.

## Usage
Use examples liberally, and show the expected output if you can. It's helpful to have inline the smallest example of usage that you can demonstrate, while providing links to more sophisticated examples if they are too long to reasonably include in the README.

## Support
Tell people where they can go to for help. It can be any combination of an issue tracker, a chat room, an email address, etc.

## Roadmap
If you have ideas for releases in the future, it is a good idea to list them in the README.

## Contributing
State if you are open to contributions and what your requirements are for accepting them.

For people who want to make changes to your project, it's helpful to have some documentation on how to get started. Perhaps there is a script that they should run or some environment variables that they need to set. Make these steps explicit. These instructions could also be useful to your future self.

You can also document commands to lint the code or run tests. These steps help to ensure high code quality and reduce the likelihood that the changes inadvertently break something. Having instructions for running tests is especially helpful if it requires external setup, such as starting a Selenium server for testing in a browser.

## Authors and acknowledgment
Show your appreciation to those who have contributed to the project.

## License
For open source projects, say how it is licensed.

## Project status
If you have run out of energy or time for your project, put a note at the top of the README saying that development has slowed down or stopped completely. Someone may choose to fork your project or volunteer to step in as a maintainer or owner, allowing your project to keep going. You can also make an explicit request for maintainers.

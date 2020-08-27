# TankSumo_EverFa11
Small game
## Dowload using git
1. Proceed to the outside of the unity project folder, right click somewhere else and select "Git bash here".
2. Once the bash is opened, type in following:
  'git clone "https://github.com/yunomin/TankSumo_EverFa11.git"'
  This will create a github repo forlder along with your unity project folder. 
## Create new branch of your work and try combining your work
1. Open git bash inside local repo folder, you should be able to see the branch name in the end of the prompt, default should be "master".
2. Use the following to create a new branch with a meaningful name.
  'git checkout -b "branch_name"'
  You should be able to see the branch name on the prompt change. 
3. Copy and paste everything from the unity project folder to the local repo folder. ~~it will probabily delete everthing that you download from github but I guess that can be fixed when merging branches later on~~
4. Use the following to upload to github.
  'git add .'
  'git commit -m "Description of the work"'
  'git push origin "branch_name'

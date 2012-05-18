##HelloWorld

For BAND gig 4/24/2012 - Community Development

###GitHub Learning Exercise

**1. Fork the BangorDevelopers\HelloWorld repository**

- Browse to https://github.com/BangorDevelopers/HelloWorld
- Click the 'Fork' button

It now exists in your GitHub Online Repository.

**2. Download the code (clone command)**

Open the Git Bash command prompt type
Navigate to the working directory where you want to store your github repositories
$ cd Documents/github/

Use the clone command to make a local copy of the remote repository
To get a list of git commands type
$ git help

To get help for any git command type
$ git help <command>
for example
$ git help clone

Here is the clone command to make a local copy of the HelloWorld repository in your current directory
replace USERNAME with your github username
you will be asked to enter your passphrase

$ git clone git@github.com:USERNAME/HelloWorld.git 

With Windows Explorer browse to your local copy working directory 
if you set your working directory: '\My Documents\github\HelloWorld' 
Otherwise: C:\Users\<WindowsUserName>\

Meta data about your local GitHub repository is in the .git folder


**3. Link back to the original repository (remote command)**

In order to submit changes back to the orginal repository at BangorDevelopers
you will need to link to it.

Set your git working directory to the repository root
From the git command prompt type:
$ cd HelloWorld

use the git remote command to create the link
$ git remote add upstream git://github.com/BangorDevelopers/HelloWorld.git

This adds a new entry to the .git\config file, creating an alias to the parent repository.
'upstream' is just a convention used for the parent alias
When you cloned the repository the default 'origin' remote link was created


**4. Make some changes to the local project**

Open the HelloWorld Solution in VisualStudio.
Compile.  It should build successfully

[[During the BAND gig, this is where Jeff provides an overview of the project]]

Run to the see the output

Add your own class in the Services folder that implements ISayHello

Run to see the results of your class output


**5. Finalize your changes and upload to your forked remote repository**

Before submitting your changes to the parent 'BangorDevelopers' you must
tell git about the changes you made (add command)

$ git add --all

commit these changes - this does not upload them yet.
This is making a snapshot of your changes known to the local repository.
Add a comment so you know what you changed
$ git commit -m "Added new ISayHello provider"

Before you push your changes you should merge with the parent to resolve any conflicts
$ git fetch upstream
$ git fetch merge upstream/master

(You can use "$git pull upstream to do this in one step", but you may wish to review differences before merging.
using'$git diff')

Upload your changes to your remote repository
$ git push


**6. Request that your update be pulled into the parent repository **

Depending on your role on the team in the parent project, you may not have rights to push directly
to the parent repository.

To get your code accepted, you must send a 'Pull Request'

Browser to your repository on github.com
https://github.com/USERNAME/HelloWorld

Click the 'Pull Request' button

- Enter a subject and description for the Pull Request
- Review the Commits
- Review the Files Changed
- submit the pull request


**Congratulations! You are done!**



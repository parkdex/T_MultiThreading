## Setup upstream remote

Already fork repository clone to local.

### Check remote repository

git remote -v

### Add remote add upstream

git remote add upstream "URL"

## Update 

### Update to local master

git checkout master
git fetch upstream
git merge upstream/master

or

git pull upstream master

## Reference link

https://json.postype.com/post/210431

---
Title: How do you rename a Git tag?
Published: 2017-04-19
Image: /assets/posts/jon-tyson-566CgCRSNCk-unsplash.jpg
---

Here is how I rename a tag `old` to `new`:

```bash
git tag new old
git tag -d old
git push origin :refs/tags/old
git push --tags
```

The colon in the push command removes the tag from the remote repository. If you don't do this, git will create the old tag on your machine when you pull.

Finally, make sure that the other users remove the deleted tag. Please tell them(co-workers) to run the following command:

```bash
git pull --prune --tags
```

Source [StackOverflow](http://stackoverflow.com/questions/1028649/how-do-you-rename-a-git-tag)


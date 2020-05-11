---
Title: Configure SourceTree to stash before pull & unstash after merge
Published: 2017-09-28
Image: assets/posts/source-tree-dialog.png
---

[SourceTree](https://www.sourcetreeapp.com/) is my favourite tool for a while i used it when working with Git repositories, as i'm [GitFlow](http://nvie.com/posts/a-successful-git-branching-model/) addict and often create branches during my work, and SourceTree helps a lot with this.

But it's a headache to see this message, when i wanna pull a branch while having local changes:
![](assets/posts/source-tree-dialog.png)

to solve this i must go into shell and type:

```bash
git stash
git pull --rebase
git stash pop
```

Also we can pack this into Custom Action and use from context menu:


![](assets/posts/source-tree-custom-actions.png)

Another way is to use a feature that is supported natively by Git since [v2.7.0](https://developer.atlassian.com/blog/2016/01/git-2.7-release). All you need to do is set the following global config flag:

```bash
git config --global rebase.autostash true
```

And now we no longer dependent on SourceTree to have this feature. Enjoy!
---
Title: Configure SourceTree to stash before pull & unstash after merge
Published: 2017-09-28
Image: /assets/posts/yancy-min-842ofHC6MaI-unsplash.jpg

ImageAuthor: Yancy Min
ImageLink: https://unsplash.com/photos/842ofHC6MaI
---

<a class="hover:text-teal-600 no-underline text-teal-500 hover:underline" target="_blank" href="https://www.sourcetreeapp.com/">SourceTree</a> is my favourite tool for a while i used it when working with Git repositories.
 
As i'm <a class="hover:text-teal-600 no-underline text-teal-500 hover:underline" target="_blank" href="https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow">GitFlow</a> addict and often create feature and release branches during my work, and SourceTree helps a lot with this.

But it's a headache to see this message, when i wanna pull a branch while having local changes:

![](/assets/posts/source-tree-dialog.png)

to solve this i must go into shell and type:

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
git stash
git pull --rebase
git stash pop
</pre>
Also we can pack this into Custom Action and use from context menu:

![](/assets/posts/source-tree-custom-actions.png)

Another way is to use a feature that is supported natively by Git since <a class="hover:text-teal-600 no-underline text-teal-500 hover:underline" target="_blank" href="https://developer.atlassian.com/blog/2016/01/git-2.7-release">v2.7.0</a>. 

All you need to do is set the following global config flag:

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
git config --global rebase.autostash true
</pre>

And now we no longer dependent on SourceTree to have this feature. 

Enjoy!
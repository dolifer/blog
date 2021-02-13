---
Title: How do you rename a Git tag?
Published: 2017-04-19
Image: /assets/posts/brett-jordan-B9N22h2s0to-unsplash.jpg

ImageAuthor: Brett Jordan
ImageLink: https://unsplash.com/photos/B9N22h2s0to
---

Here is how I rename a tag `old` to `new`:

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
git tag new old
git tag -d old
git push origin :refs/tags/old
git push --tags
</pre>

The colon in the push command removes the tag from the remote repository. If you don't do this, git will create the old tag on your machine when you pull.

Finally, make sure that the other users remove the deleted tag. 

Please tell them(co-workers) to run the following command:

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
git pull --prune --tags
</pre>

Source <a class="hover:text-blue-600 no-underline text-blue-500 hover:underline" target="_blank" href="http://stackoverflow.com/questions/1028649/how-do-you-rename-a-git-tag">StackOverflow</a>


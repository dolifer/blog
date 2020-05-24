---
Title: Updating Assembly Redirects with NuGet
Published: 2017-09-20
Image: /assets/posts/john-lockwood-FcLq69V7Rsc-unsplash.jpg

ImageAuthor: John Lockwood
ImageLink: https://unsplash.com/photos/FcLq69V7Rsc
---

This is one of those "note to self" posts. Every time i've got something like this:

![](assets/posts/vs-redirect-warning.png)

I'm telling NuGet to explicitly re-write assembly redirects in project `.config` file based on the installed NuGet packages:

![](assets/posts/vs-add-binding-redirect.png)

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
PM> Add-BindingRedirect
</pre>

But not everyone knows that we can do this for _all projects_ in solution:

![](assets/posts/vs-add-binding-redirect-all-projects.png)

<pre class="bg-gray-800 rounded text-white font-mono text-base p-2 my-2">
PM> Get-Project –All | Add-BindingRedirect
</pre>

NuGet will get all projects and for every project, add the correct assembly binding redirects again. Compile, run, and continue your day without rage. 

Enjoy!


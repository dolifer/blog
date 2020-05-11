---
Title: Updating Assembly Redirects with NuGet
Published: 2017-09-20
Image: /assets/posts/todo_cover.jpg
---

This is one of those "note to self" posts. Every time i've got something like this:

![](assets/posts/vs-redirect-warning.png)

I'm telling NuGet to explicitly re-write assembly redirects in project .config files based on the installed NuGet Packages:

![](assets/posts/vs-add-binding-redirect.png)

```
PM> Add-BindingRedirect
```

But not everyone knows that we can do this for _all projects_ in solution:

![](assets/posts/vs-add-binding-redirect-all-projects.png)

```
PM> Get-Project –All | Add-BindingRedirect
```

NuGet will get all projects and for every project, add the correct assembly binding redirects again. Compile, run, and continue your day without rage. Enjoy!


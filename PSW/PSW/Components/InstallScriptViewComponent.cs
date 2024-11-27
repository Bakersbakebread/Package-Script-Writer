using Microsoft.AspNetCore.Mvc;

using PSW.Models;

namespace PSW.Components;

[ViewComponent(Name = "InstallScript")]
public class InstallScriptViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(bool hasQueryString, PackagesViewModel packagesViewModel)
    {
        var model = new InstallScriptViewModel(hasQueryString, packagesViewModel);
        return View($"{ViewComponentContext.ViewComponentDescriptor.FullName}.cshtml", model);
    }
}
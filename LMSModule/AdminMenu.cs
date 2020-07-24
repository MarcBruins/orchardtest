using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

public class AdminMenu : INavigationProvider
    {
        private readonly IStringLocalizer S;

        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            S = localizer;
        }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            // We want to add our menus to the "admin" menu only.
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            // Adding our menu items to the builder.
            // The builder represents the full admin menu tree.
            builder
                .Add(S["LMS"], S["LMS"].PrefixPosition(),  rootView => rootView               
                    .Add(S["Module uploaden"], S["Module uploaden"].PrefixPosition(), childOne => childOne
                        .Action("ModuleUploaden", "Home", new { area = "LMSModule"})));

            return Task.CompletedTask;
        }
    }
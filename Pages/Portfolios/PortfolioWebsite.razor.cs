﻿using Microsoft.AspNetCore.Components;

namespace IdeaAppCore.Pages.Portfolios
{
    public partial class PortfolioWebsite
    {
        [Inject]
        public NavigationManager NavigationManagerReference { get; set; }

        protected override void OnInitialized()
        {
        }

        private void GoToPortSites()
        {
            NavigationManagerReference.NavigateTo("/Index");
        }
    }
}

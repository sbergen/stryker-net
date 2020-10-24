﻿using Stryker.Core.Exceptions;

namespace Stryker.Core.Options.Options
{
    public class ProjectUnderTestNameFilterOption : BaseStrykerOption<string>
    {
        public ProjectUnderTestNameFilterOption(string projectUnderTestNameFilter)
        {
            if (projectUnderTestNameFilter is { })
            {
                if (projectUnderTestNameFilter.IsNullOrEmptyInput())
                {
                    throw new StrykerInputException("Project under test name filter cannot be empty.");
                }

                Value = projectUnderTestNameFilter;
            }
        }

        public override StrykerOption Type => StrykerOption.ProjectUnderTestNameFilter;
        public override string HelpText => @"Used for matching the project references when finding the project to mutate. Example: ""ExampleProject.csproj""";
    }
}

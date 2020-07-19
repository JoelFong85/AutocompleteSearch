# Search Autocomplete

Search Autocomplete is a feature to search for GitHub repos by keying search terms. 

As the user keys in search terms, the feature will provide autocomplete suggestions based on the top 10 repos returned from GitHub search API.(https://developer.github.com/v3/search/).

Built using AngularJS (FE) & .NET APIs (BE).

## Requirements
- Developed on Visual Studio 2019 (VS). Tested & works on 2017 as well.
- .NET version 4.6.1 (initially written in .NET version 4.7.2 but downgraded in case other machines don't have the latest)

## Installation

- Open GitBash & navigate to preferred directory for cloning.
- Key in:
```bash
git clone https://github.com/JoelFong85/AutocompleteSearch.git
```
- Open solution in VS.
- Build solution (ctrl-shift-B). Dependencies will be downloaded for the build.
- Run project in IIS Express (Google Chrome preferred).

## WIP
Only the autocomplete function is complete. Clicking the search button will not provide any functionality at the moment.
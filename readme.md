<a href="https://openupm.com/packages/com.jeffcampbellmakesgames.entitasredux/"><img src="https://img.shields.io/npm/v/com.jeffcampbellmakesgames.entitasredux?label=openupm&amp;registry_uri=https://package.openupm.com" /></a>
<img alt="GitHub issues" src="https://img.shields.io/github/issues/jeffcampbellmakesgames/EntitasRedux?style=flat-square">[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40stampyturtle-blue.svg?style=flat&label=Follow)](https://twitter.com/stampyturtle)

<a href='https://ko-fi.com/I3I2W7GX' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

# Entitas Redux

## About
Entitas Redux is a reworked version of [Entitas](https://github.com/sschmid/Entitas-CSharp) with a sole focus on Unity. I had several goals as I started developing this re-envisioned version.

* _I wanted a version of Entitas I could more actively add features, bug fixes, and improvements to_.  At the time, Entitas had not received active development for the better part of a year.

* _I wanted a more straightforward development environment with all source provided_. While Entitas was largely open-source, there were core parts of the code-generation framework that did not have source code provided. I've written or maintained several code-gen tools previously and so to make this a fully-open source library (and split up responsibilities between code generator and ECS framework) I've adapted the best parts of the original Entitas code-gen and several internal solutions into a new general-purpose code generation tool for Unity named [Genesis](https://github.com/jeffcampbellmakesgames/Genesis). This can be freely used, forked, and adapted for whatever code-gen purposes in Unity you might need, and is a core dependency of Entitas Redux.

* _I wanted increased iteration times and a simpler way to extend and build upon the API_. Entitas was originally setup as a plain-old CSharp solution where the code-base was split between many assemblies, including optional Unity support and some, but not all unit. When making changes, these assemblies needed to be recompiled and published to a Unity project along with any included scripts to be tested. The abstract setup for me was increasing iteration time, making it harder to debug issues in the Unity Editor, and extending functionality in small ways required referencing many assemblies to do so. As a result, I have reworked the development environment, now consisting of a Unity project containing all of the reworked EntitasRedux framework code, unit tests, and example content. In this way, it is easy to test

* _I wanted to be able to immediately test changes using all unit tests and example content_. The original CSharp solution contained a majority of unit tests, but not all as there were Unity specific-tests in several scattered Unity projects). The majority of unit tests themselves were written using a unit test library named NSpec, but Unity primarily uses NUnit. In order to have a single Unity development project able to run all unit tests (edit-mode, play-mode), I ported all of the original NSpec unit tests to NUnit and imported and reworked all disparate Unity test content into a single development project.

* _Singular focus on Unity_. The abstractions of the original development environment makes sense when there is a desire to support non-Unity C# applications as the Unity integration is optional, but I had no such aspiration as I work fully in Unity. This has enabled me to collapse many of the previously-existing related assemblies into Runtime, Editor, and Plugin versions and remove functionality not pertinent for Unity such as server or CLI code-gen, CSharp project manipulation, among others. I can also now issue updates and releases easily as Packages, making it easy for downstream applications to always be on the latest version if they choose to.

### TLDR

* Entitas Redux is an updated, worked version of Entitas that is easy to develop for and against. All unit tests and example content are available in the same repository and distribution of new versions is now easy to do with a few clicks. 
* It has a more modern, updated C# code style.
* Over time, I want to enhance the feature set even more for Unity developers and provide a more robust unit and performance testing suite for the framework.

### Outstanding Features

As I reworked Entitas, I focused on the unit tests firsts and then used those as a guide as I reworked the development environment and cleaned up the code base to reflect a more modern C# style (for code style guidelines, please see [here](CONTRIBUTING.md)). There were two significant features that while updated require further investigation before including them into the main library and have been left orphaned onto indidividual branches from `develop` for now.

* **Blueprints**: This was a feature intended to make it possible to configure Entities in the Unity Editor. In their original form they were no longer supported or included with official releases of Entitas and have been relegated to a beta state. See [here](https://github.com/sschmid/Entitas-CSharp/wiki/Entitas-Blueprints) for more information on their original intended use.

* **Migrations**: This was a CLI/Editor tool for migrating existing code to the latest Entitas API. This is something I am uncertain if I want to commit to at this time and don't largely see using myself, but did update so that it was compatible with the rest of the code-base if there was strong enough interest.

## Installing Entitas Redux
Using this library in your project can be done in three ways:

### Install via OpenUPM
The package is available on the [openupm registry](https://openupm.com/). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
openupm add com.jeffcampbellmakesgames.entitasredux
```

### Install via GIT URL
Using the native Unity Package Manager introduced in 2017.2, you can add this library as a package by modifying your `manifest.json` file found at `/ProjectName/Packages/manifest.json` to include it as a dependency. See the example below on how to reference it.

```
{
	"dependencies": {
		...
		"com.jeffcampbellmakesgames.genesis" : "https://github.com/jeffcampbellmakesgames/genesis.git#release/stable",
		"com.jeffcampbellmakesgames.entitasredux" : "https://github.com/jeffcampbellmakesgames/entitasredux.git#release/stable",
		...
	}
}
```


You will need to have Git installed and available in your system's PATH.

### Install via classic `.UnityPackage`
The latest release can be found [here](https://github.com/jeffcampbellmakesgames/entitasredux/releases) as a UnityPackage file that can be downloaded and imported directly into your project's Assets folder.

## Usage

Entitas Redux at the moment is largely representative of the features present in `v1.13.0` of Entitas. As a temporary solution for now, I would point you to the Entitas Wiki [here](https://github.com/sschmid/Entitas-CSharp/wiki/Tutorials) for a breakdown on features and documentation on usage. In the future, EntitasRedux documentation and code examples will be hosted on this repository.

## Support
If this is useful to you and/or you’d like to see future development and more tools in the future, please consider supporting it either by contributing to the Github projects (submitting bug reports or features and/or creating pull requests) or by buying me coffee using any of the links below. Every little bit helps!

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I3I2W7GX)

## Contributing

For information on how to contribute and code style guidelines, please visit [here](CONTRIBUTING.md).
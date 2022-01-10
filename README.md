# Frends.Community.Utilities

frends Community Task for SmallFUnctions

[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.Utilities/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.Utilities/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.Utilities) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [SmallFUnctions](#SmallFUnctions)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the Task via frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.Utilities

# Tasks

## Echo

Repeats a message given as input. 

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `string` | Some string that will be repeated. | `foo` |

### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `string` | Repeated string. | `foo` |




## AlwaysTrue

Returns true.

### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `bool` | Repeated string. | `foo, foo, foo` |



## ThrowException

Throws an exception with given message. 

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| message | `string` | Some string that will be repeated. | `There was an error.` |

### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `bool` | This task won't actually ever return anything as it always throws an exception. Its return type is how ever boolean. | `undefined` |



## Replace

Replaces parts from strings that match a regular expression pattern with a specified replacement string.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `string` | A string where parts are replaced. | `foobar` |
| pattern | `string` | A regular expression pattern.</ | `o+` |
| replacement | `string` | A replacement. | `arm` |


### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `string` | Some string that will be repeated. | `farmbar` |


## Match

Returns the results from a single regular expression.


### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `string` | A string where parts are matched. | `foobar` |
| pattern | `string` | A regular expression pattern.</ | `o+` |


### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `string` | A first occurrence of matches. | `oo` |



## Split

Splits an input string into an array of substrings at the positions defined by a regular expression match.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `string` | A string where parts are matched. | `foobar` |
| pattern | `string` | A regular expression pattern.</ | `o+` |


### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `string[]` | A array of substrings. | `["f", "bar"]` |

## Sleep

A cancellable task that will complete after a time delay.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| hours | `int` | Hours being waited. | `0` |
| minutes | `int` | Minutes being waited. | `0` |
| seconds | `int` | Seconds being waited. | `10` |
| milliseconds | `int` | Milliseconds being waited. | `0` |

### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `bool` | Always returns true after waiting. | `true` |



## ConvertToJArray

Converts input to JArray. Input is only item of returned JArray. If input is already a JArray Task just returns it. 

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `dynamic` | Some data for JArray. | `{"foo": "bar"}` |


### Returns

| Type | Description | Example |
| -------- | -------- | -------- |
| `JArray` | Data that is JArray. | `[{"foo": "bar"}]` |


## Dump

Dumps content of object.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| input | `dynamic` | Any object | ```new Dictionary<int, string>
{
    [7] = "seven",
    [9] = "nine",
    [13] = "thirteen"
}``` |


### Returns

| Property     | Type	    | Description    | Example        |
|:------------|----------:|----------------|----------------|
| Type | `Object` | Type of an abject.  | ```System.Collections.Generic.Dictionary`2[System.Int32,System.String]``` |
| ConsoleStyle | `Object` | Human readable version of data.  | ```{ 7, "seven" }
{ 9, "nine" }
{ 13, "thirteen" }``` |
| CSharpStyle | `Object` | C# to create data.  | ```var dictionary = new Dictionary<int, string>
{
  { 7, "seven" },
  { 9, "nine" },
  { 13, "thirteen" }

};``` |

Task does not work so well with Newtonsoft types, but still gives you a hint. For example with input `Newtonsoft.Json.Linq.JToken.FromObject(new { Age = 10, Name = "Fluffy" })` task gives you 

| Property     | Type	    | Description    | Value        |
|:------------|----------:|----------------|----------------|
| Type | `Object` | `Newtonsoft.Json.Linq.JObject` |
| ConsoleStyle | `Object` |   `{}` |
| CSharpStyle | `Object` |  ```var jObject = new JObject
{
  new JProperty
  {
    new JValue
    {
    }
  },
  new JProperty
  {
    new JValue
    {
    }
  }
}``` |


# Building

Clone a copy of the repository

`git clone https://github.com/CommunityHiQ/Frends.Community.Utilities.git`

Rebuild the project

`dotnet build`

Run tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repository on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 0.0.1   | Development still going on |

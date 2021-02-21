# DocFx.Plugins.Kroki

![](https://ci.appveyor.com/api/projects/status/github/Arkezar/DocFx.Plugins.Kroki?svg=true)

This is a plugin for DocFx to allow rendering diagrams with kroki.io service in DFM documents.

## Installation

1. Using nuget install to the project directory

```command
nuget install DocFx.Plugins.Kroki -ExcludeVersion -OutputDirectory .
```

2. Add to `docfx.json`

```json
...
    "template": [
      "default",
      "DocFx.Plugins.Kroki"
    ]
...
```

## Usage

Add code block to your markup:

````markdown
```<diagram type>

<diagram source>

```
````

Supported diagram types:
- `BlockDiag`
- `BPMN`
- `Bytefield`
- `SeqDiag`
- `ActDiag`
- `NwDiag`
- `PacketDiag`
- `RackDiag`
- `C4PlantUML`
- `Ditaa`
- `Erd`
- `Excalidraw`
- `GraphViz`
- `Mermaid`
- `Nomnoml`
- `PlantUML`
- `Svgbob`
- `UMlet`
- `Vega`
- `VegaLite`
- `WaveDrom`

Example:

````markdown
```plantuml
Bob->Alice : hello
```
````

### Settings

Plugin can be configured in `docfx.json`.

|Setting|Description|Default|
|-------|-----------|-------|
|kroki.serviceUrl|Url to remote service|https://kroki.io/|
|kroki.outputFormat|Diagram output format, check supported output at [kroki.io](https://kroki.io/#support)|svg|

Example:

```json
...
    "markdownEngineProperties": {
      "kroki.serviceUrl": "http://localhost:8000/",
      "kroki.outputFormat": "svg"
    }
...
```
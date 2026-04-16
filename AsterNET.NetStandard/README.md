# Pazkov.AsterNET.NetStandard

Fork of [MRebati/AsterNET.NetStandard](https://github.com/MRebati/AsterNET.NetStandard) with Asterisk 12+ compatibility fixes.

## Changes from upstream (2.2.1)

- **AbstractAgentEvent**: Added `Interface` property (Asterisk 12+)
- **AgentsEvent**: Added `TalkingToChan`, `CallStarted`, `ChannelState`, `ChannelStateDesc`, `CallerIDNum`, `CallerIDName`, `ConnectedLineNum`, `ConnectedLineName`, `AccountCode`, `Context`, `Exten`, `Priority`, `Linkedid`
- **QueueMemberEvent**: Added `Interface` and `InCall` properties
- **AgentConnectEvent**: Updated `BridgedChannel` docs (removed in Asterisk 12)

These changes mirror the fixes applied to [AsterNET upstream](https://github.com/AsterNET/AsterNET) in commits `9dc2564` and `697e289`.

## Installation

```
dotnet add package Pazkov.AsterNET.NetStandard
```

﻿namespace BleBoxModels.Common.Enums;

public enum TunnelStatus
{
    WaitingForWiFi,
    Connecting,
    DnsFailed,
    ServerNotFound,
    ConnectionBroken,
    Connected,
    DisabledByUser
}

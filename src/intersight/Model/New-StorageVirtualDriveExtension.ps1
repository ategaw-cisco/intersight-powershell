function New-StorageVirtualDriveExtension {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AccountMoid},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.MoBaseMoRef[]]]
        ${Ancestors},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreateTime},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ModTime},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Moid},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[String[]]]
        ${Owners},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.MoBaseMoRef]]
        ${Parent},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.MoTag[]]]
        ${Tags},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.MoVersionContext]]
        ${VersionContext},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DeviceMoId},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Dn},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Rn},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Bootable},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ContainerId},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DriveState},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OperDeviceId},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.AssetDeviceRegistrationRef]]
        ${RegisteredDevice},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.StorageControllerRef]]
        ${StorageController},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Uuid},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VendorUuid},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.StorageVirtualDriveRef]]
        ${VirtualDrive},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VirtualDriveDn},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VirtualDriveId}
    )

    Process {
        'Creating object: intersight.Model.StorageVirtualDriveExtension' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.StorageVirtualDriveExtension -ArgumentList @(
            ${AccountMoid},
            ${Ancestors},
            ${CreateTime},
            ${ModTime},
            ${Moid},
            ${ObjectType},
            ${Owners},
            ${Parent},
            ${Tags},
            ${VersionContext},
            ${DeviceMoId},
            ${Dn},
            ${Rn},
            ${Bootable},
            ${ContainerId},
            ${DriveState},
            ${Name},
            ${OperDeviceId},
            ${RegisteredDevice},
            ${StorageController},
            ${Uuid},
            ${VendorUuid},
            ${VirtualDrive},
            ${VirtualDriveDn},
            ${VirtualDriveId}
        )
    }
}

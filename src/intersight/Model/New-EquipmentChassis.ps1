function New-EquipmentChassis {
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
        ${Model},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Revision},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Serial},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Vendor},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.ComputeBladeRef[]]]
        ${Blades},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.EquipmentFanModuleRef[]]]
        ${Fanmodules},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.EquipmentIoCardRef[]]]
        ${Ioms},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OperState},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.EquipmentPsuRef[]]]
        ${Psus},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.AssetDeviceRegistrationRef]]
        ${RegisteredDevice},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.StorageSasExpanderRef[]]]
        ${Sasexpanders},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.EquipmentSystemIoControllerRef[]]]
        ${Siocs},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.StorageEnclosureRef[]]]
        ${StorageEnclosures}
    )

    Process {
        'Creating object: intersight.Model.EquipmentChassis' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.EquipmentChassis -ArgumentList @(
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
            ${Model},
            ${Revision},
            ${Serial},
            ${Vendor},
            ${Blades},
            ${Fanmodules},
            ${Ioms},
            ${OperState},
            ${Psus},
            ${RegisteredDevice},
            ${Sasexpanders},
            ${Siocs},
            ${StorageEnclosures}
        )
    }
}

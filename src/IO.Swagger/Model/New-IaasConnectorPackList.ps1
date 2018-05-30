function New-IaasConnectorPackList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IaasConnectorPack[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IaasConnectorPackList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IaasConnectorPackList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}

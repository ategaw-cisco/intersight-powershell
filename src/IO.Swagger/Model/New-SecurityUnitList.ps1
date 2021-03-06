function New-SecurityUnitList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.SecurityUnit[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.SecurityUnitList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.SecurityUnitList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}

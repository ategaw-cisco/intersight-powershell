function New-IamEndPointUserList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IamEndPointUser[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IamEndPointUserList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IamEndPointUserList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}

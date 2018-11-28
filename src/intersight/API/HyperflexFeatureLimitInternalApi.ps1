function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Boolean]
        ${$count},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$inlinecount},
        [Parameter(Position = 2, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${$top},
        [Parameter(Position = 3, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${$skip},
        [Parameter(Position = 4, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$filter},
        [Parameter(Position = 5, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$select},
        [Parameter(Position = 6, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$orderby},
        [Parameter(Position = 7, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$expand},
        [Parameter(Position = 8, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$apply},
        [Parameter(Position = 9, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${at}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsGet(
            ${$count},
            ${$inlinecount},
            ${$top},
            ${$skip},
            ${$filter},
            ${$select},
            ${$orderby},
            ${$expand},
            ${$apply},
            ${at}
        )
    }
}

function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsMoidDelete {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsMoidDelete' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsMoidDelete(
            ${moid}
        )
    }
}

function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsMoidGet(
            ${moid}
        )
    }
}

function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitInternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitInternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsMoidPost(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexFeatureLimitInternalApiHyperflexFeatureLimitInternalsPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitInternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitInternalApi-HyperflexFeatureLimitInternalsPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitInternalApi.HyperflexFeatureLimitInternalsPost(
            ${body}
        )
    }
}


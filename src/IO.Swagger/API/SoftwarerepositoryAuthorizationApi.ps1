function Invoke-SoftwarerepositoryAuthorizationApiSoftwarerepositoryAuthorizationsGet {
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
        'Calling method: SoftwarerepositoryAuthorizationApi-SoftwarerepositoryAuthorizationsGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:SoftwarerepositoryAuthorizationApi.SoftwarerepositoryAuthorizationsGet(
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

function Invoke-SoftwarerepositoryAuthorizationApiSoftwarerepositoryAuthorizationsMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: SoftwarerepositoryAuthorizationApi-SoftwarerepositoryAuthorizationsMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:SoftwarerepositoryAuthorizationApi.SoftwarerepositoryAuthorizationsMoidGet(
            ${moid}
        )
    }
}

function Invoke-SoftwarerepositoryAuthorizationApiSoftwarerepositoryAuthorizationsMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.SoftwarerepositoryAuthorization]
        ${body}
    )

    Process {
        'Calling method: SoftwarerepositoryAuthorizationApi-SoftwarerepositoryAuthorizationsMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:SoftwarerepositoryAuthorizationApi.SoftwarerepositoryAuthorizationsMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-SoftwarerepositoryAuthorizationApiSoftwarerepositoryAuthorizationsMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.SoftwarerepositoryAuthorization]
        ${body}
    )

    Process {
        'Calling method: SoftwarerepositoryAuthorizationApi-SoftwarerepositoryAuthorizationsMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:SoftwarerepositoryAuthorizationApi.SoftwarerepositoryAuthorizationsMoidPost(
            ${moid},
            ${body}
        )
    }
}

function Invoke-SoftwarerepositoryAuthorizationApiSoftwarerepositoryAuthorizationsPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.SoftwarerepositoryAuthorization]
        ${body}
    )

    Process {
        'Calling method: SoftwarerepositoryAuthorizationApi-SoftwarerepositoryAuthorizationsPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:SoftwarerepositoryAuthorizationApi.SoftwarerepositoryAuthorizationsPost(
            ${body}
        )
    }
}


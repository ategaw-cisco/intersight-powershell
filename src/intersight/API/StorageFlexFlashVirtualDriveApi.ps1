function Invoke-StorageFlexFlashVirtualDriveApiStorageFlexFlashVirtualDrivesGet {
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
        'Calling method: StorageFlexFlashVirtualDriveApi-StorageFlexFlashVirtualDrivesGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:StorageFlexFlashVirtualDriveApi.StorageFlexFlashVirtualDrivesGet(
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

function Invoke-StorageFlexFlashVirtualDriveApiStorageFlexFlashVirtualDrivesMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: StorageFlexFlashVirtualDriveApi-StorageFlexFlashVirtualDrivesMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:StorageFlexFlashVirtualDriveApi.StorageFlexFlashVirtualDrivesMoidGet(
            ${moid}
        )
    }
}

function Invoke-StorageFlexFlashVirtualDriveApiStorageFlexFlashVirtualDrivesMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.StorageFlexFlashVirtualDrive]
        ${body}
    )

    Process {
        'Calling method: StorageFlexFlashVirtualDriveApi-StorageFlexFlashVirtualDrivesMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:StorageFlexFlashVirtualDriveApi.StorageFlexFlashVirtualDrivesMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-StorageFlexFlashVirtualDriveApiStorageFlexFlashVirtualDrivesMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.StorageFlexFlashVirtualDrive]
        ${body}
    )

    Process {
        'Calling method: StorageFlexFlashVirtualDriveApi-StorageFlexFlashVirtualDrivesMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:StorageFlexFlashVirtualDriveApi.StorageFlexFlashVirtualDrivesMoidPost(
            ${moid},
            ${body}
        )
    }
}


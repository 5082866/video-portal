﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

angular.module('directives.examplecard', []).directive('cbExampleCard', [
    function() {
        return {
            restrict: 'EA',
            require: 'ngModel',
            replace: true,
            scope: {
                model: '=ngModel'
            },
            templateUrl: 'portal.example-card.html'
        };
    }
]);
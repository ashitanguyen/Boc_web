var myApp = angular.module('myApp', ['dx']);

myApp.controller('myController', function myController($scope) {

    var vm = this;

    vm.ATAData = [];
    vm.ATAData = [
        {
            "iStatus": 1,
            "aName": "7:45",
            "aDesc": "7:45",
            "aPercentComplete": 0,
            "sColor": "Red"
        },
        {
            "iStatus": 2,
            "aName": "",
            "aDesc": "",
            "aPercentComplete": 50,
            "sColor": ""
        },
        {
            "iStatus": 3,
            "aName": "8:00",
            "aDesc": "8:00",
            "aPercentComplete": 100,
            "sColor": "Yellow"
        }
    ];

    vm.statusData = [];
    vm.statusData = [
        {
            "iStatus": 1,
            "sName": "No Work",
            "sDesc": "No Work Done",
            "dPercentComplete": 0,
            "sColor": "Red"
        },
        {
            "iStatus": 2,
            "sName": "WIP",
            "sDesc": "Work In Progress",
            "dPercentComplete": 50,
            "sColor": "Yellow"
        },
        {
            "iStatus": 3,
            "sName": "Complete",
            "sDesc": "Work Complete",
            "dPercentComplete": 100,
            "sColor": "Green"
        }
    ];

    vm.laborData = [];
    vm.laborData = [
        {
            "iLDId": 1,
            "iStatus": 1,
            "dtStart": "2017-09-01",
            "dtEnd": "2018-10-31",
            "dHours": 140,
            
        },
        {
            "iLDId": 2,
            "iStatus": 2,
            "dtStart": "2017-09-01",
            "dtEnd": "2018-10-31",
            "dHours": 280,
        },
        {
            "iLDId": 3,
            "iStatus": 3,
            "dtStart": "2017-09-01",
            "dtEnd": "2018-10-31",
            "dHours": 420,
        }
    ];

    $scope.gridData = {
        dataSource: vm.laborData,
        onCellPrepared: function (e) {
            if (e.rowType != "data" || e.columnIndex != 1)
                return;

            // debugger;  
            var color = e.column.lookup.items[e.value - 1].sColor
            e.cellElement.css('backgroundColor', color);

        },
        columns: [
            {
                dataField: "iLDId",
                caption: "ID",
                width: 100
            },
            {
                dataField: "iStatus",
                caption: "ATA",
                width: 200,
                lookup: { dataSource: vm.ATAData, valueExpr: "iStatus", displayExpr: "aName" }
            },
            {
                dataField: "iStatus",
                caption: "Status",
                width: 200,
                lookup: { dataSource: vm.statusData, valueExpr: "iStatus", displayExpr: "sName" }
            },
            {
                dataField: "dtStart",
                caption: "Start Date",
                width: 200,
                dataType: "date"
            },
            {
                dataField: "dtEnd",
                caption: "End Date",
                width: 200,
                dataType: "date"
            },
            {
                dataField: "dHours",
                caption: "Total Hours",
                width: 200,
                dataType: "number"
            }
        ]
    };// end of gridData



}); // end of controller
$(document).ready(function () {
    initGrid();
});

function formatNum(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')
}


function initGrid(data) {
    $("#dataHome").DataTable({
        scrollX: true,
        ordering: false,
        order:[[0,"asc"]],
        serverSide: true,
        processing: true,
        ajax: {
            url: urlGetData,
            type: 'POST'
        },
        columns: [
            {
                title: "CMGUnmaskedID",
                data: "cmgUnmaskedID",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    var link = '<a href="' + urlDetail + '/' + row.cmgUnmaskedID + '">' + row.cmgUnmaskedID + '</a>';
                    return link;
                }
            },
            {
                title: "CMGUnmaskedName",
                data: "cmgUnmaskedName",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "ClientTier",
                data: "clientTier",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "GCPStream",
                data: "gcpStream",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "GCPBusiness",
                data: "gcpBusiness",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "CMGGlobalBU",
                data: "cmgGlobalBU",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "CMGSegmentName",
                data: "cmgSegmentName",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "GlobalControlPoint",
                data: "globalControlPoint",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "GCPGeography",
                data: "gcpGeography",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "GlobalRelationshipManagerName",
                data: "globalRelationshipManagerName",
                searchable: false,
                autoWidth: true,
            },
            {
                title: "REVENUE_FY14",
                data: "revenuE_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.revenuE_FY14);
                }
            },
            {
                title: "REVENUE_FY15",
                data: "revenuE_FY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.revenuE_FY15);
                }
            },
            {
                title: "Deposits_EOP_FY14",
                data: "deposits_EOP_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.deposits_EOP_FY14);
                }
            },
            {
                title: "Deposits_EOP_FY15x",
                data: "deposits_EOP_FY15x",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.deposits_EOP_FY15x);
                }
            },
            {
                title: "TotalLimits_EOP_FY14",
                data: "totalLimits_EOP_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.totalLimits_EOP_FY14);
                }
            },
            {
                title: "TotalLimits_EOP_FY15",
                data: "totalLimits_EOP_FY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.totalLimits_EOP_FY15);
                }
            },
            {
                title: "TotalLimits_EOP_FY15x",
                data: "totalLimits_EOP_FY15x",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.totalLimits_EOP_FY14);
                }
            },
            {
                title: "RWAFY15",
                data: "rwafY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.rwafY15);
                }
            },
            {
                title: "RWAFY14",
                data: "rwafY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.rwafY14);
                }
            },
            {
                title: "REV/RWA FY14",
                data: "reV_RWA_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.reV_RWA_FY14) + "%";
                }
            },
            {
                title: "REV/RWA FY15",
                data: "reV_RWA_FY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.reV_RWA_FY15) + "%";
                }
            },
            {
                title: "NPAT_AllocEq_FY14",
                data: "npaT_AllocEq_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.npaT_AllocEq_FY14);
                }
            },
            {
                title: "NPAT_AllocEq_FY15X",
                data: "npaT_AllocEq_FY15X",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.npaT_AllocEq_FY15X);
                }
            },
            {
                title: "Company_Avg_Activity_FY14",
                data: "company_Avg_Activity_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.company_Avg_Activity_FY14);
                }
            },
            {
                title: "Company_Avg_Activity_FY15",
                data: "company_Avg_Activity_FY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.company_Avg_Activity_FY15);
                }
            },
            {
                title: "ROE_FY14",
                data: "roE_FY14",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.roE_FY14) + "%";
                }
            },
            {
                title: "ROE_FY15",
                data: "roE_FY15",
                searchable: false,
                autoWidth: true,
                render: function (data, type, row, meta) {
                    return formatNum(row.roE_FY15) + "%";
                }
            }
        ]
    });
}
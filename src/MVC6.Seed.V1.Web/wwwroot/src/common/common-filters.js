function sanitizeHtml($sce) {
    // TODO: ng annotate
    return html => {
        return $sce.trustAsHtml(html);
    };
}

let commonFilters = angular.module('rr.common.filters', [])
    .filter('angular-namespace-prefixSanitizeHtml', sanitizeHtml)
    .name;

export { commonFilters };



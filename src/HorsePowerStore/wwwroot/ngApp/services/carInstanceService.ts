﻿namespace HorsePowerStore.Services {
    export class CarInstanceService {
        private carInstanceResource
        public car;

        constructor($resource: ng.resource.IResourceService) {
            this.carInstanceResource = $resource('/api/carInstances/', {}, {
                'overwrite': {
                    method: 'POST',
                    url: '/api/carInstances/overwrite'
                }
            });
        }

        public listCarInstances() {
            return this.carInstanceResource.query();
        }

        public saveCarInstance(carInstance) {
            // Default ID so server knows this is a new car
            carInstance.id = 0;
            return this.carInstanceResource.save(carInstance).$promise;
        }

        public overwriteCarInstance(carInstance) {
            return this.carInstanceResource.overwrite(carInstance).$promise;
        }
    }
    angular.module('HorsePowerStore').service('carInstanceService', CarInstanceService);
}
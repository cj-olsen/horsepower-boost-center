namespace HorsePowerStore.Controllers {

    export class AccountController {
        public externalLogins;

        public getUserName() {
            return this.accountService.getUserName();
        }

        public getClaim(type) {
            return this.accountService.getClaim(type);
        }

        public isLoggedIn() {
            return this.accountService.isLoggedIn();
        }
        

        public logout() {
            this.accountService.logout();
            this.$location.path('/');
        }

        public getExternalLogins() {
            return this.accountService.getExternalLogins();
        }

        constructor(private accountService: HorsePowerStore.Services.AccountService, private $location: ng.ILocationService) {
            this.getExternalLogins().then((results) => {
                this.externalLogins = results;
            });
        }
    }
    angular.module('HorsePowerStore').controller('AccountController', AccountController);


    export class LoginController {
        public loginUser;
        public validationMessages;
        private modalInstance: ng.ui.bootstrap.IModalServiceInstance;

        constructor(
            private $uibModal: angular.ui.bootstrap.IModalService,
            private $scope: angular.IScope,
            private accountService: HorsePowerStore.Services.AccountService,
            private $location: ng.ILocationService, ) { }

        public login() {
            this.accountService.login(this.loginUser).then(() => {
                this.ok();
                this.$location.path('/');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }
        
        public openLoginDialog() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/login.html',
                scope: this.$scope,
                size: 'sm'
            });
        }

        public ok() {
            this.modalInstance.close();
        }

        public cancel() {
            this.modalInstance.close();
        }
    }
    angular.module('HorsePowerStore').controller('LoginController', LoginController);

    export class RegisterController {
        public registerUser;
        public validationMessages;
        private modalInstance: ng.ui.bootstrap.IModalServiceInstance;

        constructor(
            private $uibModal: angular.ui.bootstrap.IModalService,
            private $scope: angular.IScope,
            private accountService: HorsePowerStore.Services.AccountService,
            private $location: ng.ILocationService) { }

        public register() {
            this.accountService.register(this.registerUser).then(() => {
                this.ok();
                this.$location.path('/');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        public openRegisterDialog() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/register.html',
                scope: this.$scope,
                size: 'sm'
            });
        }

        public ok() {
            this.modalInstance.close();
        }

        public cancel() {
            this.modalInstance.close();
        }
    }
    angular.module('HorsePowerStore').controller('RegisterController', RegisterController);

    export class ExternalRegisterController {
        public registerUser;
        public validationMessages;

        public register() {
            this.accountService.registerExternal(this.registerUser.email)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }

        constructor(
            private accountService: HorsePowerStore.Services.AccountService,
            private $location: ng.ILocationService) { }
    }

    export class ConfirmEmailController {
        public validationMessages;

        constructor(
            private accountService: HorsePowerStore.Services.AccountService,
            private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $location: ng.ILocationService
        ) {
            let userId = $stateParams['userId'];
            let code = $stateParams['code'];
            accountService.confirmEmail(userId, code)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }
    }

}

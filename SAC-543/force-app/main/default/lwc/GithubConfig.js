import { LightningElement, track, api } from 'lwc';

export default class ConfigureGithub extends LightningElement {

    @track githubUsername;
    @track githubPassword;
    @track githubUrl;
    @track repositoryName;
    @track noOfEntries;
    @track pageNumber;
    @track title;
    @track username;
    @track url;
    
    @track showLogin;
    @track showHome;
    @track showConfigure;
    @track showGitHub;
    @track showList;
    @track showPopup;

    handleWebsiteNavigation() {
        this.showLogin = true;
        this.showHome = false;
        this.showConfigure = false;
        this.showGitHub = false;
        this.showList = false;
        this.showPopup = false;
    }

    handleLogin() {
        if (this.validateLogin()) {
            this.showHome = true;
            this.showLogin = false;
        }
    }

    handleConfigure() {
        this.showConfigure = true;
        this.showHome = false;
        this.showGitHub = false;
    }

    handleGitHub() {
        this.showGitHub = true;
        this.showConfigure = false;
        this.showPopup = true;
    }

    handleSave() {
        const isValidated = this.validateGitHubDetails();
        if (isValidated) {
            this.showList = true;
            this.showPopup = false;
            this.showGitHub = false;
        }
    }

    handleReset() {
        this.githubUsername = '';
        this.githubPassword = '';
        this.githubUrl = '';
        this.repositoryName = '';
    }

    handleEdit(event) {
        this.title = event.target.title;
        this.username = event.target.username;
        this.url = event.target.url;
        this.showPopup = true;
    }

    handleDelete(event) {
        // Code for deletion
    }

    handleShowEntries(event) {
        this.noOfEntries = event.target.value;
    }

    handlePagination(event) {
        this.pageNumber = event.target.value;
    }

    handleAddMore() {
        this.showPopup = true;
        this.showList = false;
    }

    validateLogin() {
        // Code for validation
    }

    validateGitHubDetails() {
        // Code for validation
    }

}
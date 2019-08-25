pipeline {
    agent any

    triggers {
        pollSCM('*/5 * * * *')
    }

    stages {    
        stage('Restore Packages') {
            steps {
                sh 'dotnet restore'
            }
        }
        
        stage('Clean') {
            steps {
                sh 'dotnet clean'
            }
        }
        
        stage('Build') {
            steps {
                sh 'dotnet build'
            }
        }
        
        stage('Test') {
            steps {
                sh 'dotnet test'
            }
        }
        
        stage('Deploy Master') {
            when { branch 'master' }
            steps {
                echo 'Deploy master will be here'
            }
        }

        stage('Deploy Dev') {
            when { branch 'dev' }
            steps {
                echo 'Deploy dev will be here'
            }
        }

        stage('Do not deploy') {
            when {
                not {
                    anyOf {
                        branch 'master';
                        branch 'dev'
                    }
                }
            }
            steps {
                echo 'Nothing is deployed'
            }
        }
    }
}
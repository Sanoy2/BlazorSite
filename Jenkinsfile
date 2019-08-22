pipeline {
    agent any

    triggers {
        pollSCM('15 * * * *')
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
        
        stage('Deploy') {
            steps {
                echo 'Deploy  will be here'
            }
        }
    }
}
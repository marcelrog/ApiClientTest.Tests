pipeline {
    agent any

    tools {
        nodejs 'Node20'
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Verify Node') {
            steps {
                bat 'node -v'
                bat 'npm -v'
            }
        }

        stage('Install Playwright') {
            steps {
                bat 'npm install -D @playwright/test'
                bat 'npx playwright install'
            }
        }

        stage('Run Playwright Tests') {
            steps {
                bat 'npx playwright test --reporter=html'
            }
        }

        stage('Publish Report') {
            steps {
                publishHTML(target: [
                    reportDir: 'playwright-report',
                    reportFiles: 'index.html',
                    reportName: 'Playwright Report'
                ])
            }
        }
    }
}

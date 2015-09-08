module.exports = function(grunt) {
	grunt.initConfig({
		watch: {
            livereload: {
                options: {
                    livereload: 1337
                },
                files: [
                    '**/*.js'
                ]
            }
        },
        connect: {
        	server: {
        		options: {
        			port: 6546,
        			base: '',
        			livereload: 1337,
        			open: true
        		}
        	}
        }
	});

	grunt.loadNpmTasks('grunt-contrib-watch');
	grunt.loadNpmTasks('grunt-contrib-connect');
	grunt.registerTask('default', ['connect', 'watch']);
};